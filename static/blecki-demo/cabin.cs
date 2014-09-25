public class cabin : RMUD.Room
{
	public override void Initialize()
	{
		Short = "The sunken cabin";
        Long = "The floor of the cabin is ankle deep, except in that spot where it is very suddenly waist deep. Broken windows look out over the sea, and the control panel pukes out it's guts into the water. The wheel, the dials, everything is gone, replaced with a mass of decaying wire.";

		OpenLink(RMUD.Direction.AFT, "blecki-demo/deck");
	}
}
