﻿using ArnaldoDiBianco.UserControls;
using ArnaldoDiBianco.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ArnaldoDiBianco
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private MainWindowViewModel _vm { get; }

		public MainWindow()
		{
			InitializeComponent();
			_vm = (MainWindowViewModel)DataContext;
			cbListItemTypes.Items.Clear();
			foreach (var item in Enums.Names.ListItemTypeNames.OrderBy(p => p.Key).Select(p => p.Value))
				cbListItemTypes.Items.Add(item);
			Task.Run(() =>
			{
				Task.Delay(4000).Wait();
				Dispatcher.Invoke(() => transitioner.SelectedIndex = 1);
			});
		}

		private void btnRemove_Click(object sender, RoutedEventArgs e)
		{
			if (itemsList.Items.Count > 0 && MessageBox.Show("Sei sicuro che vuoi cancellare questo elemento?", "Conferma", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
				itemsList.Items.Remove(sender);
		}

		private void btnClear_Click(object sender, RoutedEventArgs e)
		{
			if (itemsList.Items.Count > 0 && MessageBox.Show("Sei sicuro che vuoi cancellare tutti gli elementi?", "Conferma", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
				itemsList.Items.Clear();
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			ListItemContainer item = null;
			switch (cbListItemTypes.SelectedIndex)
			{
				default:
					return;
				case (int)Enums.ListItemTypes.FinestraPersiana1anta:
					item = new ListItemContainer(Enums.ListItemTypes.FinestraPersiana1anta);
					break;
				case (int)Enums.ListItemTypes.FinestraPersiana2ante:
					item = new ListItemContainer(Enums.ListItemTypes.FinestraPersiana2ante);
					break;
				case (int)Enums.ListItemTypes.Finestra1anta:
					item = new ListItemContainer(Enums.ListItemTypes.Finestra1anta);
					break;
				case (int)Enums.ListItemTypes.Finestra2ante:
					item = new ListItemContainer(Enums.ListItemTypes.Finestra2ante);
					break;
				case (int)Enums.ListItemTypes.PortaBalcone1anta:
					item = new ListItemContainer(Enums.ListItemTypes.PortaBalcone1anta);
					break;
				case (int)Enums.ListItemTypes.PortaBalcone2ante:
					item = new ListItemContainer(Enums.ListItemTypes.PortaBalcone2ante);
					break;
			}
			item.RemoveClicked = btnRemove_Click;
			itemsList.Items.Add(item);
			itemsList.ScrollIntoView(item);
		}

		private void btnCalcAll_Click(object sender, RoutedEventArgs e)
		{
			_vm.Reset();
			foreach (ListItemContainer item in itemsList.Items)
			{
				item.Calculate();
				//var type = item.ItemType;
				var model = item.Model;
				_vm.TelaioBombato += model.PersianeSheet ? model.TelaioX : 0;
				_vm.TelaioDritto += model.PersianeSheet ? 0 : model.TelaioX;
				_vm.Sottotelaio += model.PersianeSheet ? 0 : model.SottotelaioX;
				_vm.Anta += model.Anta;
				_vm.TdiRiporto += model.TdiRiportoX + 0 /*finestre - Porta balcone 2 ante*/;
				_vm._40X20 += model.PersianeSheet ? model._40X20X : 0;
				_vm.Fascione += model.FascioneX;
				_vm.Zoccolo += model.ZoccoloX;
				_vm.Compensatore += model.PersianeSheet ? model.CompensatoreX : 0;
				_vm.MezzaLamella += model.PersianeSheet ? model.MezzaLamellaX : 0;
				_vm.Lamella += model.PersianeSheet ? model.LamellaX : 0;
			}
			#region / 650
			_vm.TelaioBombato /= 650;
			_vm.TelaioBombato = Math.Round(_vm.TelaioBombato, 1);
			_vm.TelaioDritto /= 650;
			_vm.TelaioDritto = Math.Round(_vm.TelaioDritto, 1);
			_vm.Sottotelaio /= 650;
			_vm.Sottotelaio = Math.Round(_vm.Sottotelaio, 1);
			_vm.Anta /= 650;
			_vm.Anta = Math.Round(_vm.Anta, 1);
			_vm.TdiRiporto /= 650;
			_vm.TdiRiporto = Math.Round(_vm.TdiRiporto, 1);
			_vm._40X20 /= 650;
			_vm._40X20 = Math.Round(_vm._40X20, 1);
			_vm.Fascione /= 650;
			_vm.Fascione = Math.Round(_vm.Fascione, 1);
			_vm.Zoccolo /= 650;
			_vm.Zoccolo = Math.Round(_vm.Zoccolo, 1);
			_vm.Compensatore /= 650;
			_vm.Compensatore = Math.Round(_vm.Compensatore, 1);
			_vm.MezzaLamella /= 650;
			_vm.MezzaLamella = Math.Round(_vm.MezzaLamella, 1);
			_vm.Lamella /= 650;
			_vm.Lamella = Math.Round(_vm.Lamella, 1);
			#endregion
			_vm.RaiseAllPropertiesChanged();
			_total.IsExpanded = true;
		}
	}
}
