class sitting_room : RMUD.Room
{
    public override void Initialize()
    {
        Short = "A dusty sitting room";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/bed-and-breakfast/kitchen");
        OpenLink(RMUD.Direction.UP, "port-ivy/bed-and-breakfast/hallway");
    }
}