class scenery_lamp : RMUD.Scenery
{
    public scenery_lamp()
    {
        AddValueRule<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => RMUD.LightingLevel.Bright);
    }

    public scenery_lamp(string Short, string Long)
        : base(Short, Long)
    {
        AddValueRule<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(a => RMUD.LightingLevel.Bright);
    }
}