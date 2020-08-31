using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for Finestra1anta.xaml
	/// </summary>
	public partial class Finestra1anta : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }

		private Finestra1antaViewModel _vm
		{
			get => (Finestra1antaViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public Finestra1anta()
		{
			InitializeComponent();
			_vm = (Finestra1antaViewModel)DataContext;
			_vm.PersianeSheet = false;
		}

		public bool Calculate(decimal larghezza, decimal altezza)
		{
			try
			{
				var telaio = larghezza + altezza * 2;
				var anta = Math.Max(0, (larghezza - 9) * 2 + (altezza - 6) * 2);
				var model = new FinestraPersiana1antaViewModel
				{
					Telaio = telaio,
					Anta = anta,
					Sottotelaio = Math.Max(0, larghezza - 4),
					Regolatori = larghezza <= 0 ? 0 : 4,
					Squadrette = larghezza <= 0 ? 0 : 8,
					Cerniere = larghezza <= 0 ? 0 : 2,
					Guarnizione = telaio + anta,
					Asta = larghezza <= 0 ? 0 : altezza - 40,
					IncontroAsta = larghezza <= 0 ? 0 : 2,
					CremoneseFinestra = larghezza <= 0 ? 0 : 1,
					Puntali = larghezza <= 0 ? 0 : 2,
					CoppiaCursoriManiglia = larghezza <= 0 ? 0 : 1
				};
				_vm.Telaio = model.Telaio;
				_vm.Anta = model.Anta;
				_vm.Sottotelaio = model.Sottotelaio;
				_vm.Regolatori = model.Regolatori;
				_vm.Squadrette = model.Squadrette;
				_vm.Cerniere = model.Cerniere;
				_vm.Guarnizione = model.Guarnizione;
				_vm.Asta = model.Asta;
				_vm.IncontroAsta = model.IncontroAsta;
				_vm.CremoneseFinestra = model.CremoneseFinestra;
				_vm.Puntali = model.Puntali;
				_vm.CoppiaCursoriManiglia = model.CoppiaCursoriManiglia;
				_vm.UpdateQuantity();
			}
			catch (Exception ex)
			{
				return false;
			}
			return true;
		}
	}
}
