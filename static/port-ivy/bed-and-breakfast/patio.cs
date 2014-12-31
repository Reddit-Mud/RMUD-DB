class patio : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Patio";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/kitchen", GetObject("port-ivy/bed-and-breakfast/patio_door"));
        OpenLink(RMUD.Direction.WEST, "port-ivy/Beach__West_Side_0");
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/deck");        
    }
}

