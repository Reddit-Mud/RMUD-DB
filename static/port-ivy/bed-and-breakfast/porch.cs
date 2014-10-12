class porch : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Exterior;
        Short = "Port Ivy - Bed and Breakfast - Porch";

        OpenLink(RMUD.Direction.EAST, "port-ivy/Main_St_North_0");
        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/sitting_room", RMUD.Mud.GetObject("port-ivy/bed-and-breakfast/front_door"));
        
    }
}

