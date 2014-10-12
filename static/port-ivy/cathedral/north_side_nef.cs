public class north-side-nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The North nef";
        Long = "Here is half of Jesus' path of the cross. At one end there is the confessional and a path to reach the main nef. At the other end there is a path to get to the entrance.";

		AddScenery (new SmallCandle());
        Openlink(RMUD.Direction.NORTH, "port-ivy/cathedral/confessional");
        Openlink(RMUD.Direction.SOUTH, "port-ivy/cathedral/entrance");
        Openlink(RMUD.Direction.EAST, "port-ivy/cathedral/main_nef");
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