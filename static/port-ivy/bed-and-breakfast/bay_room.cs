//import window

class bay_room : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Bay Room";
        Long = "This room is named for the large window which dominates the western side. It's a bay window, obviously, and gives a great view of the ocean.";

        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/hallway", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/bay_room_door"));
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/deck", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/deck_door"));

        AddScenery(new window("bay window", "port-ivy/beach_1"));
    }
}

