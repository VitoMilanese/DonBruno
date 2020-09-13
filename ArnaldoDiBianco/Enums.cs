using System.Collections.Generic;

namespace ArnaldoDiBianco.Enums
{
	public enum ListItemTypes
	{
		Finestra1anta = 0,
		Finestra2ante = 1,
		PortaBalcone1anta = 2,
		PortaBalcone2ante = 3,
		FinestraPersiana1anta = 4,
		FinestraPersiana2ante = 5,
		PortaBalconePersiana1anta = 6,
		PortaBalconePersiana2ante = 7,
		FinestraScorrevole = 8
	}

	public static class Names
	{
		public static Dictionary<ListItemTypes, string> ListItemTypeNames = new Dictionary<ListItemTypes, string>
		{
			{ ListItemTypes.FinestraPersiana1anta, "Finestra Persiana 1 anta" },
			{ ListItemTypes.FinestraPersiana2ante, "Finestra Persiana 2 ante" },
			{ ListItemTypes.Finestra1anta, "Finestra 1 anta" },
			{ ListItemTypes.Finestra2ante, "Finestra 2 ante" },
			{ ListItemTypes.PortaBalconePersiana1anta, "Porta Balcone Persiana 1 anta" },
			{ ListItemTypes.PortaBalconePersiana2ante, "Porta Balcone Persiana 2 ante" },
			{ ListItemTypes.PortaBalcone1anta, "Porta Balcone 1 anta" },
			{ ListItemTypes.PortaBalcone2ante, "Porta Balcone 2 ante" },
			{ ListItemTypes.FinestraScorrevole, "Finestra scorrevole" },
		};
	}
}
