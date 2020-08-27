using ArnaldoDiBianco.ViewModels;

namespace ArnaldoDiBianco.UserControls
{
	public interface IListItem
	{
		ListItemViewModel viewModel { get; set; }
		public int Quantita
		{
			get => viewModel.Quantita;
			set => viewModel.Quantita = value;
		}

		bool Calculate(decimal larghezza, decimal altezza);
	}
}
