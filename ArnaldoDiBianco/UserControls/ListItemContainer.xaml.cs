using ArnaldoDiBianco.ViewModels;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for WindowListItem.xaml
	/// </summary>
	public partial class ListItemContainer : UserControl
	{
		private ListItemContainerViewModel _vm { get; }
		public Enums.ListItemTypes ItemType { get; private set; }
		public ListItemViewModel Model => ((IListItem)_content.Content)?.viewModel;

		public ListItemContainer(Enums.ListItemTypes type)
		{
			InitializeComponent();
			ItemType = type;
			_vm = (ListItemContainerViewModel)DataContext;
			_vm.Title = Enums.Names.ListItemTypeNames[type];
			_vm.ImageSource = $"../Images/{Enums.Names.ListItemTypeNames[ItemType].Replace(" ", string.Empty)}.png";
			_vm.QuantitySelected = cbQuantity_Selected;
			_vm.BackgroundA = (SolidColorBrush)FindResource("MaterialDesignBackground");
			_vm.BackgroundB = (SolidColorBrush)FindResource("MaterialDesignBackground2");
			cbQuantity.Items.Clear();
			for (var i = 1; i <= 25; ++i)
				cbQuantity.Items.Add(i);
			cbQuantity.SelectedValue = 1;
			switch (type)
			{
				case Enums.ListItemTypes.FinestraPersiana1anta:
					_content.Content = new FinestraPersiana1anta();
					break;
				case Enums.ListItemTypes.FinestraPersiana2ante:
					_content.Content = new FinestraPersiana2ante();
					break;
				case Enums.ListItemTypes.Finestra1anta:
					break;
				case Enums.ListItemTypes.Finestra2anta:
					break;
				case Enums.ListItemTypes.PortaBalconePersiana1anta:
					break;
				case Enums.ListItemTypes.PortaBalconePersiana2ante:
					break;
				case Enums.ListItemTypes.PortaBalcone1anta:
					break;
				case Enums.ListItemTypes.PortaBalcone2ante:
					break;
				case Enums.ListItemTypes.PortaFinestra1anta:
					break;
				case Enums.ListItemTypes.PortaFinestra2ante:
					break;
				default:
					throw new Exception("Unknown item type");
			}
		}

		private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !IsTextAllowed(e.Text);
		}

		private static readonly Regex _regex = new Regex("[^0-9]+"); //regex that matches disallowed text
		private static bool IsTextAllowed(string text)
		{
			return !_regex.IsMatch(text);
		}

		private bool expandAfterCalculated = true;
		public void Calculate()
		{
			expandAfterCalculated = false;
			btnCalc_Click(btnCalc, new RoutedEventArgs());
			expandAfterCalculated = true;
		}

		private void btnCalc_Click(object sender, RoutedEventArgs e)
		{
			if (((IListItem)_content.Content).Calculate(_vm.Larghezza, _vm.Altezza))
			{
				_noContent.Visibility = Visibility.Collapsed;
				_content.Visibility = Visibility.Visible;
				if (expandAfterCalculated)
					_expander.IsExpanded = true;
				_vm.Calculated = true;
			}
			else
				MessageBox.Show("Fallito", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
		}

		private void cbQuantity_Selected(object sender, int quantity)
		{
			((IListItem)_content.Content).Quantita = quantity;
			if (_vm.Calculated)
				btnCalc_Click(btnCalc, new RoutedEventArgs());
		}

		public EventHandler<RoutedEventArgs> RemoveClicked { get; set; }
		private void btnRemove_Click(object sender, RoutedEventArgs e)
			=> RemoveClicked?.Invoke(this, new RoutedEventArgs());
	}
}
