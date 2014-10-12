class main_street_1 : RMUD.Room
{
    public override void Initialize()
    {
        Short = "Port Ivy - Main Street, North End";

        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/porch");

        RMUD.MudObject.Move(new flashlight(), this);
    }
}

class flashlight : RMUD.MudObject, RMUD.EmitsLight
{
    public flashlight()
        : base("flashlight", "This is a basic flashlight. It's rather bright.")
    { }



    public RMUD.LightingLevel EmitsLight
    {
        get { return RMUD.LightingLevel.Bright; }
    }
}