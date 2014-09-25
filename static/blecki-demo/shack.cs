public class shack : RMUD.Room
{
	public override void Initialize()
	{
		Short = "a dirty shack";
        Long = "This shack manages to house, despite being smaller than most bathrooms, a bed, a table, a cooking surface, a television, and a shower. Calling any of these things small would be redundant. Of course they are small. They all match, as if they were sold as a set.";

		OpenLink(RMUD.Direction.NORTH, "blecki-demo/shoreline");

        RMUD.Thing.Move(RMUD.Mud.GetObject("blecki-demo/lighthouse_key") as RMUD.Thing, this);
        RMUD.Thing.Move(new television(), this);
	}
}

public class television : RMUD.Thing, RMUD.ITakeRules, RMUD.ILocaleDescriptionRules
{
    public television() //pun
    {
        Short = "broken television";
        Nouns.Add("BROKEN", "TELEVISION", "TV", "TELE");
        Long = "The glass is broken. It's for the best, it's a crt. The screen wasn't even flat.";
    }

    public bool CanTake(RMUD.Actor Actor)
    {
        return true;
    }

    public RMUD.RuleHandlerFollowUp HandleTake(RMUD.Actor Actor)
    {
        if (Actor.ConnectedClient != null)
            Actor.ConnectedClient.Send("What are you going to do with a broken television?");
        return RMUD.RuleHandlerFollowUp.Stop;
    }

    public RMUD.DescriptiveText LocaleDescription
    {
        get { return "The television is broken."; }
    }
}
