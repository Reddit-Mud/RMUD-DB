class patio : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Patio";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/kitchen");
        OpenLink(RMUD.Direction.WEST, "port-ivy/beach_1");
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/deck");        
    }
}

