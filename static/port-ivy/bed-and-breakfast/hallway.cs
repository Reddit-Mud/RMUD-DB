//import scenery_lamp

class hallway : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Hallway";

        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/sitting_room");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/bay_room");
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/landing");
        
        AddScenery(new scenery_lamp("wall sconse", "A little sconse on the wall is enough to fill the hallway with light."));
    }
}

