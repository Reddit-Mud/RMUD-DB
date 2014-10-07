public class cemetery: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Exterior;
        Short = "The cemetery";
        Long = "Gravestones everywhere.";

        Openlink(RMUD.Direction.WEST, "port-ivy/cathedral/main-nef");
    }
}
