﻿class window : RMUD.Scenery
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

        Perform<RMUD.MudObject, RMUD.MudObject>("describe")
            .Do((viewer, thing) =>
            {
                var outside = RMUD.Mud.GetObject(Outside) as RMUD.Room;
                if (outside != null)
                    RMUD.GlobalRules.ConsiderPerformRule("describe-locale", outside, viewer, outside);
                else
                {
                    RMUD.Mud.SendMessage(viewer, "There seems to be a problem with the window.");
                }
                return RMUD.PerformResult.Stop;
            })
            .Name("Looking through a window rule.");

        Value<RMUD.MudObject, RMUD.LightingLevel>("emits-light").Do(EmittedLight);
    }

    private RMUD.LightingLevel EmittedLight(RMUD.MudObject Item)
    {
        var outside = RMUD.Mud.GetObject(Outside) as RMUD.Room;
        if (outside != null) return outside.AmbientLighting - 1;
        return RMUD.LightingLevel.Dark;
    }
}