//import scenery_lamp

public class confessional: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "The confessional";
        Long = "This is a small enclosed space with an uncomfortable chair and a window with a closed wooden curtain through which the priest doesn't look at you when listening and absolving your sins.";

		AddScenery (new scenery_lamp("candle", "The small candle offers a dum light."));

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/north_side_nef");
    }
}
