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

		//public bool Calculate(decimal larghezza, decimal altezza)
		public bool Calculate(decimal B2, decimal B3)
		{
			try
			{
				var telaio = B2 + B3 * 2;
				var anta = Math.Max(0, (B2 - 9) * 2 + (B3 - 6) * 4);
				var portalamelle2coppie = Math.Max(0, B3 - 20);
				var model = new FinestraPersiana2anteViewModel
				{
					Telaio = telaio,
					Anta = anta,
					Sottotelaio = Math.Max(0, B2 - 4),
					TdiRiporto = Math.Max(0, B3 - 12), // TODO: check with Arnaldo
					Regolatori = B2 <= 0 ? 0 : 4,
					Squadrette = B2 <= 0 ? 0 : 12,
					Cerniere = B2 <= 0 ? 0 : 4,
					CoppiaTappiT = B2 <= 0 ? 0 : 1,
					Guarnizione = telaio + anta,
					Asta = B2 <= 0 ? 0 : B3 - 40,
					IncontroAsta = B2 <= 0 ? 0 : 2,
					CremoneseFinestra = B2 <= 0 ? 0 : 1,
					Puntali = B2 <= 0 ? 0 : 2,
					Catenacci = B2 <= 0 ? 0 : 1,
					CoppiaCursoriManiglia = B2 <= 0 ? 0 : 1
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
