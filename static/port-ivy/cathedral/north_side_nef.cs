//import scenery_lamp

public class north_side_nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "The North nef";
        Long = "Here is half of Jesus' path of the cross. At one end there is the confessional and a path to reach the main nef. At the other end there is a path to get to the entrance.";

		AddScenery (new scenery_lamp("candle", "The small candle offers a dim light."));
        OpenLink(RMUD.Direction.NORTH, "port-ivy/cathedral/confessional");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/entrance");
        OpenLink(RMUD.Direction.EAST, "port-ivy/cathedral/main_nef");
    }
}
