using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for PortaBalcone2ante.xaml
	/// </summary>
	public partial class PortaBalcone2ante : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }

		private PortaBalcone2anteViewModel _vm
		{
			get => (PortaBalcone2anteViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public PortaBalcone2ante()
		{
			InitializeComponent();
			_vm = (PortaBalcone2anteViewModel)DataContext;
			_vm.PersianeSheet = false;
		}

		//public bool Calculate(decimal larghezza, decimal altezza)
		public bool Calculate(decimal X2, decimal X3)
		{
			try
			{
				var telaio = X2 + X3 * 2;
				var anta = Math.Max(0, (X2 - 9) * 2 + (X3 - 6) * 4);
				var model = new FinestraPersiana1antaViewModel
				{
					Telaio = telaio,
					Anta = anta,
					Sottotelaio = Math.Max(0, X2 - 4),
					TdiRiporto = Math.Max(0, X3 - 12),
					Fascione = Math.Max(0, X2 - 34),
					Zoccolo = Math.Max(0, X2 - 34), // TODO: Check with Arnaldo
					Regolatori = X2 <= 0 ? 0 : 6,
					Squadrette = X2 <= 0 ? 0 : 12,
					Cerniere = X2 <= 0 ? 0 : 6,
					CoppiaTappiT = X2 <= 0 ? 0 : 1,
					Guarnizione = telaio + anta,
					Asta = X2 <= 0 ? 0 : X3 - 40,
					IncontroAsta = X2 <= 0 ? 0 : 2,
					CremoneseFinestra = X2 <= 0 ? 0 : 1,
					Puntali = X2 <= 0 ? 0 : 2,
					Catenacci = X2 <= 0 ? 0 : 1,
					CoppiaCursoriManiglia = X2 <= 0 ? 0 : 1
				};
				_vm.Telaio = model.Telaio;
				_vm.Anta = model.Anta;
				_vm.Sottotelaio = model.Sottotelaio;
				_vm.TdiRiporto = model.TdiRiporto;
				_vm.Fascione = model.Fascione;
				_vm.Zoccolo = model.Zoccolo;
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
