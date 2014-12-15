class window : RMUD.Scenery
{
    string Outside;

    public window() {
        Value<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(EmittedLight);
    }

    public window(string Short, string Outside, params string[] AdditionalNouns)
    {
        this.Short = Short;
        Nouns.Add(Short.Split(' '));
        Nouns.Add("WINDOW");
        Nouns.Add(AdditionalNouns);

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

        Value<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(EmittedLight);
    }

    private RMUD.LightingLevel EmittedLight(RMUD.MudObject Item)
    {
        var outside = RMUD.Mud.GetObject(Outside) as RMUD.Room;
        if (outside != null) return outside.AmbientLighting - 1;
        return RMUD.LightingLevel.Dark;
    }
}