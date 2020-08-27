using System.Collections.Generic;

namespace ArnaldoDiBianco.Enums
{
	public enum ListItemTypes
	{
		FinestraPersiana1anta = 0,
		FinestraPersiana2ante = 1,
		Finestra1anta = 2,
		Finestra2anta = 3,
		PortaBalconePersiana1anta = 4,
		PortaBalconePersiana2ante = 5,
		PortaBalcone1anta = 6,
		PortaBalcone2ante = 7,
		PortaFinestra1anta = 8,
		PortaFinestra2ante = 9
	}

	public static class Names
	{
		public static Dictionary<ListItemTypes, string> ListItemTypeNames = new Dictionary<ListItemTypes, string>
		{
			{ ListItemTypes.FinestraPersiana1anta, "Finestra Persiana 1 anta" },
			{ ListItemTypes.FinestraPersiana2ante, "Finestra Persiana 2 ante" },
			{ ListItemTypes.Finestra1anta, "Finestra 1 anta" },
			{ ListItemTypes.Finestra2anta, "Finestra 2 ante" },
			{ ListItemTypes.PortaBalconePersiana1anta, "Porta Balcone Persiana 1 anta" },
			{ ListItemTypes.PortaBalconePersiana2ante, "Porta Balcone Persiana 2 ante" },
			{ ListItemTypes.PortaBalcone1anta, "Porta Balcone 1 anta" },
			{ ListItemTypes.PortaBalcone2ante, "Porta Balcone 2 ante" },
			{ ListItemTypes.PortaFinestra1anta, "Porta Finestra 1 anta" },
			{ ListItemTypes.PortaFinestra2ante, "Porta Finestra 2 ante" }
		};
	}
}
