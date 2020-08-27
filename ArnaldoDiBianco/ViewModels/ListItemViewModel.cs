﻿namespace ArnaldoDiBianco.ViewModels
{
	public abstract class ListItemViewModel : BaseViewModel
	{
		private int _quantita = 1;
		private decimal _telaio;
		private decimal _anta;
		private decimal _compensatore;
		private decimal _portalamelle1coppia;
		private decimal _portalamelle2coppie;
		private decimal _mezzaLamella;
		private decimal _lamella;
		private decimal _40x20;
		private decimal _tDiRiporto;
		private int _numeroLamelle = -3;
		private decimal _squadrette;
		private decimal _cerniere;
		private decimal _rolli;
		private int _catenacci;
		private int _coppiaTappiTdiR;
		private decimal _guarnizione;
		private decimal _asta;
		private int _incontroAsta;
		private int _cremonesePersiana;
		private int _puntali;
		private int _regolatori = 0;

		private decimal _nBarreTelaio;
		private decimal _nBarreAnta;
		private decimal _nBarre40x20;
		private decimal _nBarreCompensatore;
		private decimal _nBarreMezzaLamella;
		private decimal _nBarreLamella;
		private decimal _nBarreAsta;

		public int Quantita
		{
			get => _quantita;
			set
			{
				if (value != _quantita)
					_quantita = value;
				RaisePropertyChanged();
				UpdateQuantity();
			}
		}

		public decimal Telaio
		{
			get => _telaio;
			set
			{
				if (value != _telaio)
				{
					_telaio = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal TelaioX => Telaio * Quantita;

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
		public decimal AntaX => Anta * Quantita;

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
		public decimal CompensatoreX => Compensatore * Quantita;

		public decimal Portalamelle1coppia
		{
			get => _portalamelle1coppia;
			set
			{
				if (value != _portalamelle1coppia)
				{
					_portalamelle1coppia = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal Portalamelle1coppiaX => Portalamelle1coppia * Quantita;

		public decimal Portalamelle2coppie
		{
			get => _portalamelle2coppie;
			set
			{
				if (value != _portalamelle2coppie)
				{
					_portalamelle2coppie = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal Portalamelle2coppieX => Portalamelle2coppie * Quantita;

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
		public decimal MezzaLamellaX => MezzaLamella * Quantita;

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
		public decimal LamellaX => Lamella * Quantita;

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
		public decimal _40X20X => _40X20 * Quantita;

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
		public decimal TdiRiportoX => TdiRiporto * Quantita;

		public int NumeroLamelle
		{
			get => _numeroLamelle;
			set
			{
				if (value != _numeroLamelle)
				{
					_numeroLamelle = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Squadrette
		{
			get => _squadrette;
			set
			{
				if (value != _squadrette)
				{
					_squadrette = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal SquadretteX => Squadrette * Quantita;

		public decimal Cerniere
		{
			get => _cerniere;
			set
			{
				if (value != _cerniere)
				{
					_cerniere = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal CerniereX => Cerniere * Quantita;

		public decimal Rolli
		{
			get => _rolli;
			set
			{
				if (value != _rolli)
				{
					_rolli = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal RolliX => Rolli * Quantita;

		public int Catenacci
		{
			get => _catenacci;
			set
			{
				if (value != _catenacci)
				{
					_catenacci = value;
					RaisePropertyChanged();
				}
			}
		}
		public int CatenacciX => Catenacci * Quantita;

		public int CoppiaTappiTdiR
		{
			get => _coppiaTappiTdiR;
			set
			{
				if (value != _coppiaTappiTdiR)
				{
					_coppiaTappiTdiR = value;
					RaisePropertyChanged();
				}
			}
		}
		public int CoppiaTappiTdiRX => CoppiaTappiTdiR * Quantita;

		public decimal Guarnizione
		{
			get => _guarnizione;
			set
			{
				if (value != _guarnizione)
				{
					_guarnizione = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal GuarnizioneX => Guarnizione * Quantita;

		public decimal Asta
		{
			get => _asta;
			set
			{
				if (value != _asta)
				{
					_asta = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal AstaX => Asta * Quantita;

		public int IncontroAsta
		{
			get => _incontroAsta;
			set
			{
				if (value != _incontroAsta)
				{
					_incontroAsta = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal IncontroAstaX => IncontroAsta * Quantita;

		public int CremonesePersiana
		{
			get => _cremonesePersiana;
			set
			{
				if (value != _cremonesePersiana)
				{
					_cremonesePersiana = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal CremonesePersianaX => CremonesePersiana * Quantita;

		public int Puntali
		{
			get => _puntali;
			set
			{
				if (value != _puntali)
				{
					_puntali = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal PuntaliX => Puntali * Quantita;

		public int Regolatori
		{
			get => _regolatori;
			set
			{
				if (value != _regolatori)
				{
					_regolatori = value;
					RaisePropertyChanged();
				}
			}
		}
		public decimal RegolatoriX => Regolatori * Quantita;

		public decimal BarreTelaio
		{
			get => _nBarreTelaio;
			set
			{
				if (value != _nBarreTelaio)
				{
					_nBarreTelaio = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal BarreAnta
		{
			get => _nBarreAnta;
			set
			{
				if (value != _nBarreAnta)
				{
					_nBarreAnta = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Barre40x20
		{
			get => _nBarre40x20;
			set
			{
				if (value != _nBarre40x20)
				{
					_nBarre40x20 = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal BarreCompensatore
		{
			get => _nBarreCompensatore;
			set
			{
				if (value != _nBarreCompensatore)
				{
					_nBarreCompensatore = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal BarreMezzaLamella
		{
			get => _nBarreMezzaLamella;
			set
			{
				if (value != _nBarreMezzaLamella)
				{
					_nBarreMezzaLamella = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal BarreLamella
		{
			get => _nBarreLamella;
			set
			{
				if (value != _nBarreLamella)
				{
					_nBarreLamella = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal BarreAsta
		{
			get => _nBarreAsta;
			set
			{
				if (value != _nBarreAsta)
				{
					_nBarreAsta = value;
					RaisePropertyChanged();
				}
			}
		}

		public void UpdateQuantity()
		{
			RaisePropertyChanged("TelaioX");
			RaisePropertyChanged("AntaX");
			RaisePropertyChanged("CompensatoreX");
			RaisePropertyChanged("Portalamelle2coppieX");
			RaisePropertyChanged("MezzaLamellaX");
			RaisePropertyChanged("LamellaX");
			RaisePropertyChanged("_40X20X");
			RaisePropertyChanged("SquadretteX");
			RaisePropertyChanged("CerniereX");
			RaisePropertyChanged("RolliX");
			RaisePropertyChanged("GuarnizioneX");
			RaisePropertyChanged("AstaX");
			RaisePropertyChanged("IncontroAstaX");
			RaisePropertyChanged("CremonesePersianaX");
			RaisePropertyChanged("PuntaliX");
			RaisePropertyChanged("TdiRiportoX");
			RaisePropertyChanged("CatenacciX");
			RaisePropertyChanged("CoppiaTappiTdiRX");
			RaisePropertyChanged("RegolatoriX");
		}
	}
}
