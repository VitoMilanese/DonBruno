using ArnaldoDiBianco.ViewModels;
using System;
using System.Windows.Controls;

namespace ArnaldoDiBianco.UserControls
{
	/// <summary>
	/// Interaction logic for FinestraPersiana1anta.xaml
	/// </summary>
	public partial class FinestraPersiana1anta : UserControl, IListItem
	{
		public ListItemViewModel viewModel { get; set; }
		
		private FinestraPersiana1antaViewModel _vm
		{
			get => (FinestraPersiana1antaViewModel)viewModel;
			set => viewModel = value;
		}

		public int Quantita
		{
			get => _vm.Quantita;
			set => _vm.Quantita = value;
		}

		public FinestraPersiana1anta()
		{
			InitializeComponent();
			_vm = (FinestraPersiana1antaViewModel)DataContext;
			_vm.NumeroLamelle = -3;
			_vm.PersianeSheet = true;
		}

		public bool Calculate(decimal larghezza, decimal altezza)
		{
			try
			{
				var telaio = larghezza + altezza * 2;
				var anta = Math.Max(0, (larghezza - 10) * 2 + (altezza - 6) * 2);
				var portalamelle1coppia = Math.Max(0, altezza - 20);
				var model = new FinestraPersiana1antaViewModel
				{
					NumeroLamelle = _vm.NumeroLamelle,
					Telaio = telaio,
					Anta = anta,
					Compensatore = Math.Max(0, (larghezza - 24) * 2),
					Portalamelle1coppia = portalamelle1coppia,
					MezzaLamella = Math.Max(0, (larghezza - 26) * 2),
					Lamella = Math.Round(larghezza <= 0 ? 0 : (larghezza - 25) * Math.Floor(portalamelle1coppia / 6), 0),
					_40X20 = Math.Max(0, larghezza - 11),
					Squadrette = larghezza <= 0 ? 0 : 8,
					Cerniere = larghezza <= 0 ? 0 : 2,
					Rolli = larghezza <= 0 ? 0 : 2,
					Guarnizione = telaio + anta,
					Asta = larghezza <= 0 ? 0 : altezza - 28,
					IncontroAsta = larghezza <= 0 ? 0 : 2,
					CremonesePersiana = larghezza <= 0 ? 0 : 1,
					Puntali = larghezza <= 0 ? 0 : 2,
				};
				//model.BarreTelaio = model.Telaio / 650;
				//model.BarreAnta = model.Anta / 650;
				//model.Barre40x20 = model._40X20 / 650;
				//model.BarreCompensatore = model.Compensatore / 650;
				//model.BarreMezzaLamella = model.MezzaLamella / 650;
				//model.BarreLamella = model.Lamella / 650;
				//model.BarreAsta = model.Asta / 650;
				_vm.NumeroLamelle = model.NumeroLamelle;
				_vm.Telaio = model.Telaio;
				_vm.Anta = model.Anta;
				_vm.Compensatore = model.Compensatore;
				_vm.Portalamelle1coppia = model.Portalamelle1coppia;
				_vm.MezzaLamella = model.MezzaLamella;
				_vm.Lamella = model.Lamella;
				_vm._40X20 = model._40X20;
				_vm.Squadrette = model.Squadrette;
				_vm.Cerniere = model.Cerniere;
				_vm.Rolli = model.Rolli;
				_vm.Guarnizione = model.Guarnizione;
				_vm.Asta = model.Asta;
				_vm.IncontroAsta = model.IncontroAsta;
				_vm.CremonesePersiana = model.CremonesePersiana;
				_vm.Puntali = model.Puntali;
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
