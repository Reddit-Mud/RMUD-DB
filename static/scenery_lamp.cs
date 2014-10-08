class scenery_lamp : RMUD.Scenery, RMUD.EmitsLight
{ 
    public scenery_lamp(string Short, string Long) : base(Short, Long) {}

    public bool EmitsLight
    {
        get
        {
            return true;
        }
    }
}