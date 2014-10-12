//import scenery_lamp

public class south_side_nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "The South nef";
        Long = "Here is a part of Jesus' path of the cross. Paths lead to the main nef and to the entrance.";

		AddScenery(new scenery_lamp("candle", "The small candle offers a dim light."));
        OpenLink(RMUD.Direction.NORTH, "port-ivy/cathedral/main_nef");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/entrance");
    }
}
