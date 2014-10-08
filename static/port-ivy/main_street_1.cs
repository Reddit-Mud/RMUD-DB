class main_street_1 : RMUD.Room
{
    public override void Initialize()
    {
        Short = "Port Ivy - Main Street, North End";

        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/porch");
    }
}