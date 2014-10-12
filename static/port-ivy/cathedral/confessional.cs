public class confessional: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The confessional";
        Long = "This is a small enclosed space with an uncomfortable chair and a window with a closed wooden curtain through which the priest doesn't look at you when listening and absolving your sins.";

		AddScenery (new SmallCandle ());

        Openlink(RMUD.Direction.SOUTH, "port-ivy/cathedral/north_side_nef");
    }
}

public class SmallCandle : RMUD.Scenery, RMUD.EmitsLight
{
	public SmallCandle() {
		Nouns.Add ("candle");
		Long = "The small candle offers a dim light.";
	}

	public RMUD.LightingLevel EmitsLight
	{
		get { return RMUD.LightingLevel.Dim; }
	}
}