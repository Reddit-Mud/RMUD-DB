class deck : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Deck";

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/bay_room");
        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/patio");        
    }
}

