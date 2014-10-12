class deck : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Deck";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/bay_room", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/deck_door"));
        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/patio");        
    }
}

