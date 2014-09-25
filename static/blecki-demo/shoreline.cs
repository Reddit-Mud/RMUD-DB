﻿public class shoreline : RMUD.Room
{
	public override void Initialize()
	{
		Short = "Shoreline";
		Long = "The lighthouse casts a long shadow across the grey sand. Waves roll in one after the other, queuing far out at see to pound at the empty stretch of beach. The land climbs suddenly upward to the north and you can hear the waves crashing violently against the cliffs there, but here they are calm and relaxing. A small shack croutches to the south, and a small boat sits anchored to the west. It is close enough that you could wade to it.";

		AddScenery("It's quite tall, though, it's supposed to be, so that's not exactly surprising.", "lighthouse", "light", "house");
		AddScenery("It's a beach. Of course there is a sand. What else would there be? The crushed shells of thousands upon thousands of tiny marine snails? ..Oh, that's exactly what there is.", "sand", "beach");
		AddScenery("You follow a wave as it appears, as far out as you can see, and rolls, relentlessly, toward shore, where it smashes itself into swirl of white foam that races up the sand and makes it slightly darker for a few moments.", "wave", "waves");

		OpenLink(RMUD.Direction.OUT, "blecki-demo/area");

		OpenLink(RMUD.Direction.WEST, "blecki-demo/deck");
		OpenLink(RMUD.Direction.NORTH, "blecki-demo/bluff");
		OpenLink(RMUD.Direction.EAST, "blecki-demo/lighthouse_lobby", RMUD.Mud.GetObject("blecki-demo/lighthouse_door"));
		OpenLink(RMUD.Direction.SOUTH, "blecki-demo/shack");
	}
}

public class beachball : RMUD.Thing
{
    public beachball()
    {
        Short = "dirty beachball";
        Nouns.Add("DIRTY", "BEACHBALL", "BALL");
        Long = "This beachball is a vibrant orange and white.. well, okay. It's a vibrant brown and slightly paler brown. But it was clearly once very nice. And very more inflated.";
    }
}
