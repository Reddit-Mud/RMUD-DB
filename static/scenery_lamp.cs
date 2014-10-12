class scenery_lamp : RMUD.Scenery, RMUD.EmitsLight
{
    public scenery_lamp() { }
    public scenery_lamp(string Short, string Long) : base(Short, Long) {}

    public RMUD.LightingLevel EmitsLight
    {
        get
        {
            return RMUD.LightingLevel.Dim;
        }
    }
}