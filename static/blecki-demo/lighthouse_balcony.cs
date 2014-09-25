public class lighthouse_balcony : RMUD.Room
{
	public override void Initialize()
	{
        Short = "The top of the Lighthouse";
        Long = "Muddy, rain streaked windows encircle the top of the stairway. The end abruptly, stabbing at the sky with jagged razor sharp fangs. Bits of the metal scaffolding still arch overhead. Where the lamp might have once stood lurks instead a gaping shaft into the depths of the structure, the same shaft the staircase wound so delicately around.";

		OpenLink(RMUD.Direction.DOWN, "blecki-demo/lighthouse_stairway");
        OpenLink(RMUD.Direction.IN, "blecki-demo/shaft");
	}
}
