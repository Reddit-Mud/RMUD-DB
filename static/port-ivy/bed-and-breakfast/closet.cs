class closet : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Closet";
        Long = "This tiny closet holds nothing but a ladder.";

        AddScenery("It's metal and bolted to the wall.", "ladder");

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/landing", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/closet_door"));
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/roof");
    }
}

