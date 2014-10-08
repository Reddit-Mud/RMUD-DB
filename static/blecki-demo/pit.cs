public class pit : RMUD.Room
{
    public override void Initialize()
    {
        Short = "The pit at the bottom";
        Long = "Here is a small, round room, rather dank. It is dome shaped, with a shaft leading upward from the middle of the dome, and a rusty ladder for access. The floor is mostly mud and bones. Red gouges decorate the masonry at about eye level. There is a grate to the west that lets in sea water, but is too small to let anything out.";

        OpenLink(RMUD.Direction.UP, "blecki-demo/shaft");
        OpenLink(RMUD.Direction.WEST, "blecki-demo/darkness", new grate());

        RMUD.Thing.Move(new skull(), this);
    }
}

public class skull : RMUD.Thing
{
    public skull()
    {
        Short = "human skull";
        Nouns.Add("HUMAN", "SKULL");
        Long = "This is a rather ordinary human skull. There is nothing remarkable about it, except for the part where it was once a living person with hopes and dreams and an obscure talent they never shared with anyone.";
    }
}

public class grate : RMUD.BasicDoor, RMUD.IOpenableRules
{
    public grate()
    {
        Short = "small metal grate";
        Long = "The metal grate is rusted, but not enough to make it brittle. It's held firmly in place.";
        Nouns.Add("GRATE");
    }

    RMUD.CheckRule RMUD.IOpenableRules.CanClose(RMUD.Actor Actor)
    {
        return RMUD.CheckRule.Disallow("It's already closed.");
    }

    RMUD.CheckRule RMUD.IOpenableRules.CanOpen(RMUD.Actor Actor)
    {
        return RMUD.CheckRule.Disallow("It's bolted to the wall.");
    }

    void RMUD.IOpenableRules.HandleClose(RMUD.Actor Actor)
    {
        throw new System.NotImplementedException();
    }

    void RMUD.IOpenableRules.HandleOpen(RMUD.Actor Actor)
    {
        throw new System.NotImplementedException();
    }

    bool RMUD.IOpenableRules.Open
    {
        get { return false; }
    }
}
