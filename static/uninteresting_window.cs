class uninteresting_window : RMUD.Scenery, RMUD.EmitsLight
{
    public uninteresting_window() { }

    public uninteresting_window(string Short, string Long) : base(Short, Long)
    {}

    public RMUD.LightingLevel EmitsLight
    {
        get {
            return RMUD.Mud.AmbientExteriorLightingLevel - 1;
        }
    }
}