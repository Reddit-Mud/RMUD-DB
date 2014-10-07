public class confessional: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The confessional";
        Long = "This is a small enclosed space with an uncomfortable chair and a window with a closed wooden curtain through which the priest doesn't look at you when listening and absolving your sins.";

        Openlink(RMUD.Direction.SOUTH, "port-ivy/cathedral/north-side-nef");
    }
}
