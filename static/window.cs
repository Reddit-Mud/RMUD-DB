class window : RMUD.Scenery, RMUD.EmitsLight
{
    string Outside;

    public window() { }

    public window(string Short, string Outside, params string[] AdditionalNouns)
    {
        this.Short = Short;
        Nouns.Add(Short.Split(' '));
        Nouns.Add("WINDOW");
        Nouns.AddRange(AdditionalNouns);

        this.Outside = Outside;

        Long = new RMUD.DescriptiveText((actor, owner) =>
        {
            var outside = RMUD.Mud.GetObject(Outside) as RMUD.Room;
            if (outside == null) return "Error.";
            var localeDescription = RMUD.Commands.LookProcessor.GenerateLocaleDescription(actor, outside, false);
            if (outside.AmbientLighting > RMUD.LightingLevel.Dark)
                return "Through the window you see\r\n" + localeDescription;
            else
                return "It is too dark to see anything through the window.";
        });
    }

    public RMUD.LightingLevel EmitsLight
    {
        get {
            var outside = RMUD.Mud.GetObject(Outside) as RMUD.Room;
            if (outside != null) return outside.AmbientLighting - 1;
            return RMUD.LightingLevel.Dark;
        }
    }
}