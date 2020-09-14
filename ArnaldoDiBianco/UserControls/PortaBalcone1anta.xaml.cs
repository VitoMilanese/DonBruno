using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for PortaBalcone1anta.xaml
	/// </summary>
	public partial class PortaBalcone1anta : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }

		private PortaBalcone1antaViewModel _vm
		{
			get => (PortaBalcone1antaViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public PortaBalcone1anta()
		{
			InitializeComponent();
			_vm = (PortaBalcone1antaViewModel)DataContext;
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
					Fascione = Math.Max(0, larghezza - 21),
					Zoccolo = Math.Max(0, larghezza - 21), // TODO: Check with Arnaldo
					Regolatori = larghezza <= 0 ? 0 : 6,
					Squadrette = larghezza <= 0 ? 0 : 8,
					Cerniere = larghezza <= 0 ? 0 : 3,
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
				_vm.Fascione = model.Fascione;
				_vm.Zoccolo = model.Zoccolo;
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
