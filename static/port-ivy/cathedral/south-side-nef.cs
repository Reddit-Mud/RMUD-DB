public class south-side-nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The South nef";
        Long = "Here is a part of Jesus' path of the cross. Paths lead to the main nef and to the entrance.";

        Openlink(RMUD.Direction.NORTH, "port-ivy/cathedral/main-nef");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/entrance");
    }
}
