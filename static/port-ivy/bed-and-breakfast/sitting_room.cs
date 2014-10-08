//import window

class sitting_room : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Sitting Room";
        Long = "This small sitting room was once very nice. Years of transient guests have worn the carpet bare in the most visible spots. There was an attempt to turn the room into some sort of museum celebrating the island and clientele, but nobody famous ever stayed here. Windows on the front of the house let in plenty of light, despite the gaudy curtains.";

        AddScenery("The curtains are covered in little pink flowers.", "gaudy", "curtains");
        AddScenery("No two flowers are the same. Except those two. And those two. Actually it's a pattern that repeats every five flowers or so.", "flowers", "little", "pink");
        AddScenery("The carpet looks quite nice in the spots that have spent the last twenty years under furniture.", "bare", "carpet");

        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/porch", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/front_door"));
        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/kitchen");
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/hallway");

        AddScenery(new window("curtained window", "port-ivy/bed-and-breakfast/porch", "curtains", "windows", "outside"));
    }
}

