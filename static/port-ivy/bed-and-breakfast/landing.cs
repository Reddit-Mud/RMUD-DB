//import scenery_lamp

class landing : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Landing";

        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/henrietta_wok_room");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/closet");
        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/hallway");
        
        AddScenery(new scenery_lamp("wall sconse", "A little sconse on the wall is enough to fill the landing with light."));
    }
}

