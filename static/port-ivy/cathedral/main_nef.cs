public class main_nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The main nef";
        Long = "Benches everywhere and not a soul in sight. The people depicted in the stained-glass window look over the desolation of such an empty gathering house. The altar is made of white marble. Behind the altar, a crucified Jesus hangs, paying for the sins of mankind. Exits lead to the north and south nefs, and a door behind the altar leads to the cemetery.";

		AddScenery(new Candles());

        OpenLink(RMUD.Direction.NORTH, "port-ivy/cathedral/north_side_nef");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/south_side_nef");
        OpenLink(RMUD.Direction.EAST, "port-ivy/Cemetery"); // TODO add door
    }
}

public class Candles : RMUD.Scenery, RMUD.EmitsLight
{
	public Candles() {
		Nouns.Add ("candles");
		Long = "The candles behind the cross offer enough light to see things clearly.";
	}

	public RMUD.LightingLevel EmitsLight
	{
		get { return RMUD.LightingLevel.Bright; }
	}
}