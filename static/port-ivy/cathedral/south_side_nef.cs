public class south-side-nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The South nef";
        Long = "Here is a part of Jesus' path of the cross. Paths lead to the main nef and to the entrance.";

		AddScenery(new SmallCandle());
        Openlink(RMUD.Direction.NORTH, "port-ivy/cathedral/main_nef");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/entrance");
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