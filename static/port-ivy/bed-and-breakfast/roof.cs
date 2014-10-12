class roof : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Roof";

        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/closet");
    }
}

