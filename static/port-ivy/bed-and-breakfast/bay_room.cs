class bay_room : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Bay Room";

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/hallway");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/deck");
        
    }
}

