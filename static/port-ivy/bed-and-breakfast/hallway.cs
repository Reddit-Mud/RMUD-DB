class hallway : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Hallway";

        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/sitting_room");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/bay_room");
        
    }
}

