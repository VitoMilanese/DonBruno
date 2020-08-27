namespace ArnaldoDiBianco.ViewModels
{
	public class MainWindowViewModel : BaseViewModel
	{
		private decimal _telaioBombato;
		private decimal _telaioDritto;
		private decimal _sottotelaio;
		private decimal _anta;
		private decimal _tDiRiporto;
		private decimal _40x20;
		private decimal _fascione;
		private decimal _zoccolo;
		private decimal _compensatore;
		private decimal _mezzaLamella;
		private decimal _lamella;

		public void Reset()
		{
			TelaioBombato = 0;
			TelaioDritto = 0;
			Sottotelaio = 0;
			Anta = 0;
			TdiRiporto = 0;
			_40X20 = 0;
			Fascione = 0;
			Zoccolo = 0;
			Compensatore = 0;
			MezzaLamella = 0;
			Lamella = 0;
			
		}

		public void RaiseAllPropertiesChanged()
		{
			RaisePropertyChanged("TelaioBombato");
			RaisePropertyChanged("TelaioDritto");
			RaisePropertyChanged("Sottotelaio");
			RaisePropertyChanged("Anta");
			RaisePropertyChanged("TdiRiporto");
			RaisePropertyChanged("_40X20");
			RaisePropertyChanged("Fascione");
			RaisePropertyChanged("Zoccolo");
			RaisePropertyChanged("Compensatore");
			RaisePropertyChanged("MezzaLamella");
			RaisePropertyChanged("Lamella");
		}

		public decimal TelaioBombato
		{
			get => _telaioBombato;
			set
			{
				if (value != _telaioBombato)
				{
					_telaioBombato = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal TelaioDritto
		{
			get => _telaioDritto;
			set
			{
				if (value != _telaioDritto)
				{
					_telaioDritto = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Sottotelaio
		{
			get => _sottotelaio;
			set
			{
				if (value != _sottotelaio)
				{
					_sottotelaio = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Anta
		{
			get => _anta;
			set
			{
				if (value != _anta)
				{
					_anta = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal TdiRiporto
		{
			get => _tDiRiporto;
			set
			{
				if (value != _tDiRiporto)
				{
					_tDiRiporto = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal _40X20
		{
			get => _40x20;
			set
			{
				if (value != _40x20)
				{
					_40x20 = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Fascione
		{
			get => _fascione;
			set
			{
				if (value != _fascione)
				{
					_fascione = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Zoccolo
		{
			get => _zoccolo;
			set
			{
				if (value != _zoccolo)
				{
					_zoccolo = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Compensatore
		{
			get => _compensatore;
			set
			{
				if (value != _compensatore)
				{
					_compensatore = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal MezzaLamella
		{
			get => _mezzaLamella;
			set
			{
				if (value != _mezzaLamella)
				{
					_mezzaLamella = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Lamella
		{
			get => _lamella;
			set
			{
				if (value != _lamella)
				{
					_lamella = value;
					RaisePropertyChanged();
				}
			}
		}
	}
}
