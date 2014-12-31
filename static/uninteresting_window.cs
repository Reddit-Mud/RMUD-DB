class uninteresting_window : RMUD.Scenery
{
    public uninteresting_window()
    {
        Value<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => AmbientExteriorLightingLevel - 1);
    }

    public uninteresting_window(string Short, string Long)
        : base(Short, Long)
    {
        Value<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => AmbientExteriorLightingLevel - 1);
    }
}