class uninteresting_window : RMUD.Scenery
{
    public uninteresting_window()
    {
        AddValueRule<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => RMUD.Mud.AmbientExteriorLightingLevel - 1);
    }

    public uninteresting_window(string Short, string Long)
        : base(Short, Long)
    {
        AddValueRule<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => RMUD.Mud.AmbientExteriorLightingLevel - 1);
    }
}