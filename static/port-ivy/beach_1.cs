class beach_1 : RMUD.Room
{
    public override void Initialize()
    {
        Short = "Port Ivy - Beach, West Side";

        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/patio");
    }
}