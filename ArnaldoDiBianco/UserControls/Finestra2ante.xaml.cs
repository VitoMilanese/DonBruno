using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for Finestra2ante.xaml
	/// </summary>
	public partial class Finestra2ante : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }

		private Finestra2anteViewModel _vm
		{
			get => (Finestra2anteViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public Finestra2ante()
		{
			InitializeComponent();
			_vm = (Finestra2anteViewModel)DataContext;
			_vm.PersianeSheet = false;
		}

		public bool Calculate(decimal larghezza, decimal altezza)
		{
			try
			{
				var telaio = larghezza + altezza * 2;
				var anta = Math.Max(0, (larghezza - 9) * 2 + (altezza - 6) * 4);
				var portalamelle2coppie = Math.Max(0, altezza - 20);
				var model = new FinestraPersiana2anteViewModel
				{
					Telaio = telaio,
					Anta = anta,
					Sottotelaio = Math.Max(0, larghezza - 4),
					TdiRiporto = Math.Max(0, altezza - 12),
					Regolatori = larghezza <= 0 ? 0 : 4,
					Squadrette = larghezza <= 0 ? 0 : 12,
					Cerniere = larghezza <= 0 ? 0 : 4,
					CoppiaTappiT = larghezza <= 0 ? 0 : 1,
					Guarnizione = telaio + anta,
					Asta = larghezza <= 0 ? 0 : altezza - 40,
					IncontroAsta = larghezza <= 0 ? 0 : 2,
					CremoneseFinestra = larghezza <= 0 ? 0 : 1,
					Puntali = larghezza <= 0 ? 0 : 2,
					Catenacci = larghezza <= 0 ? 0 : 1,
					CoppiaCursoriManiglia = larghezza <= 0 ? 0 : 1
				};
				_vm.Telaio = model.Telaio;
				_vm.Anta = model.Anta;
				_vm.Sottotelaio = model.Sottotelaio;
				_vm.TdiRiporto = model.TdiRiporto;
				_vm.Regolatori = model.Regolatori;
				_vm.Squadrette = model.Squadrette;
				_vm.Cerniere = model.Cerniere;
				_vm.CoppiaTappiT = model.CoppiaTappiT;
				_vm.Guarnizione = model.Guarnizione;
				_vm.Asta = model.Asta;
				_vm.IncontroAsta = model.IncontroAsta;
				_vm.CremoneseFinestra = model.CremoneseFinestra;
				_vm.Puntali = model.Puntali;
				_vm.Catenacci = model.Catenacci;
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
