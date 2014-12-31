//import scenery_lamp

class hallway : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Hallway";

        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/sitting_room");
        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/bay_room", GetObject("port-ivy/bed-and-breakfast/bay_room_door"));
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/landing");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/captain_jacks_room", GetObject("port-ivy/bed-and-breakfast/jacks_door"));
        
        AddScenery(new scenery_lamp("wall sconse", "A little sconse on the wall is enough to fill the hallway with light."));
    }
}

