using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for FinestraPersiana2ante.xaml
	/// </summary>
	public partial class FinestraPersiana2ante : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }

		private FinestraPersiana2anteViewModel _vm
		{
			get => (FinestraPersiana2anteViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public FinestraPersiana2ante()
		{
			InitializeComponent();
			_vm = (FinestraPersiana2anteViewModel)DataContext;
			_vm.NumeroLamelle = -3;
		}

		public bool Calculate(decimal larghezza, decimal altezza)
		{
			try
			{
				var telaio = larghezza + altezza * 2;
				var anta = Math.Max(0, (larghezza - 10) * 2 + (altezza - 6) * 4);
				var portalamelle2coppie = Math.Max(0, altezza - 20);
				var model = new FinestraPersiana2anteViewModel
				{
					NumeroLamelle = _vm.NumeroLamelle,
					Telaio = telaio,
					Anta = anta,
					Compensatore = Math.Max(0, (larghezza - 38) * 2),
					Portalamelle2coppie = portalamelle2coppie,
					MezzaLamella = Math.Max(0, (larghezza - 42) * 2),
					Lamella = Math.Round(
						larghezza <= 0 ? 0 :
						(larghezza - 40) * Math.Floor(portalamelle2coppie / 6)
						, 0),
					_40X20 = Math.Max(0, larghezza - 11),
					TdiRiporto = Math.Max(0, altezza - 12),
					Squadrette = 12,
					Cerniere = 4,
					Rolli = 4,
					Catenacci = 1,
					CoppiaTappiTdiR = 1,
					Guarnizione = telaio + anta,
					Asta = larghezza <= 0 ? 0 : altezza - 28,
					IncontroAsta = larghezza <= 0 ? 0 : 2,
					CremonesePersiana = larghezza <= 0 ? 0 : 1,
					Puntali = altezza <= 0 ? 0 : 2,
					Regolatori = larghezza <= 0 ? 0 : 4
				};
				_vm.NumeroLamelle = model.NumeroLamelle;
				_vm.Telaio = model.Telaio;
				_vm.Anta = model.Anta;
				_vm.Compensatore = model.Compensatore;
				_vm.Portalamelle2coppie = model.Portalamelle2coppie;
				_vm.MezzaLamella = model.MezzaLamella;
				_vm.Lamella = model.Lamella;
				_vm._40X20 = model._40X20;
				_vm.TdiRiporto = model.TdiRiporto;
				_vm.Squadrette = model.Squadrette;
				_vm.Cerniere = model.Cerniere;
				_vm.Rolli = model.Rolli;
				_vm.Catenacci = model.Catenacci;
				_vm.CoppiaTappiTdiR = model.CoppiaTappiTdiR;
				_vm.Guarnizione = model.Guarnizione;
				_vm.Asta = model.Asta;
				_vm.IncontroAsta = model.IncontroAsta;
				_vm.CremonesePersiana = model.CremonesePersiana;
				_vm.Puntali = model.Puntali;
				_vm.Regolatori = model.Regolatori;
				//_vm.Quantita = model.Quantita;
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
