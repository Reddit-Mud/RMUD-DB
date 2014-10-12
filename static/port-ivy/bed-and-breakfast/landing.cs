//import uninteresting_window

class landing : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Landing";

        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/henrietta_wok_room");
        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/closet", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/closet_door"));
        OpenLink(RMUD.Direction.DOWN, "port-ivy/bed-and-breakfast/hallway", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/wok_door"));
        
        AddScenery(new uninteresting_window("wall sconse", "All you can see through this window is a swatch of sky."));
    }
}

