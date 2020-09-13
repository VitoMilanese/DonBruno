using System;
using System.Windows;
using System.Windows.Media;

namespace ArnaldoDiBianco.ViewModels
{
	public class ListItemContainerViewModel : BaseViewModel
	{
		private int _quantity = 1;
		private string _title;
		private decimal _larghezza;
		private decimal _altezza;
		private bool _calculated = false;
		private bool _withSerratura;
		private Visibility _serraturaOption { get; set; } = Visibility.Collapsed;

		public ListItemContainerViewModel()
		{
			for (var i = 0; i < 100; ++i)
				Quantities[i] = i + 1;
		}

		public string Title
		{
			get => _title;
			set
			{
				if (value != _title)
				{
					_title = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Larghezza
		{
			get => _larghezza;
			set
			{
				if (value != _larghezza)
				{
					_larghezza = value;
					RaisePropertyChanged();
				}
			}
		}

		public decimal Altezza
		{
			get => _altezza;
			set
			{
				if (value != _altezza)
				{
					_altezza = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool Calculated
		{
			get => _calculated;
			set
			{
				if (value != _calculated)
				{
					_calculated = value;
					RaisePropertyChanged();
					RaisePropertyChanged("ContentVisibility");
					RaisePropertyChanged("NoContentVisibility");
					RaisePropertyChanged("BackgroundColor");
				}
			}
		}

		public Visibility ContentVisibility => _calculated ? Visibility.Visible : Visibility.Collapsed;
		public Visibility NoContentVisibility => _calculated ? Visibility.Collapsed : Visibility.Visible;

		private SolidColorBrush _backgroundA = new SolidColorBrush(Color.FromArgb(255, 221, 255, 221));
		private SolidColorBrush _backgroundB = new SolidColorBrush(Color.FromArgb(255, 255, 221, 221));
		public SolidColorBrush BackgroundA
		{
			get => _backgroundA;
			set
			{
				if (value != _backgroundA)
				{
					_backgroundA = value;
					RaisePropertyChanged();
					RaisePropertyChanged("BackgroundColor");
				}
			}
		}
		public SolidColorBrush BackgroundB
		{
			get => _backgroundB;
			set
			{
				if (value != _backgroundB)
				{
					_backgroundB = value;
					RaisePropertyChanged();
					RaisePropertyChanged("BackgroundColor");
				}
			}
		}
		public SolidColorBrush BackgroundColor => _calculated ? BackgroundA : BackgroundB;

		public int[] Quantities = new int[100];
		public EventHandler<int> QuantitySelected { get; set; }

		public int Quantity
		{
			get => _quantity;
			set
			{
				if (value != _quantity)
				{
					_quantity = value;
					RaisePropertyChanged();
					QuantitySelected?.Invoke(this, _quantity);
				}
			}
		}

		private string _imageSource = string.Empty;
		public string ImageSource
		{
			get => _imageSource;
			set
			{
				if (value != _imageSource)
				{
					_imageSource = value;
					RaisePropertyChanged();
				}
			}
		}


		public Visibility SerraturaOption
		{
			get => _serraturaOption;
			set
			{
				if (value != _serraturaOption)
				{
					_serraturaOption = value;
					RaisePropertyChanged();
				}
			}
		}

		public bool WithSerratura
		{
			get => _withSerratura;
			set
			{
				if (value != _withSerratura)
				{
					_withSerratura = value;
					RaisePropertyChanged();
				}
			}
		}
	}
}
