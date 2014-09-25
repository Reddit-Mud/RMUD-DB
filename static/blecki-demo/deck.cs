public class deck : RMUD.Room
{
	public override void Initialize()
	{
		Short = "The deck of the grounded boat";
        Long = "This boat is half underwater, though most of the deck is merely damp. Every single inch of it is covered in salt creep. Bits of rotted rope still cling to gunwales, where the gunwales haven't rusted off the sides. Rods and rotting nets and other fishing paraphenelia lie in a heap on the lower side of the deck.";

		OpenLink(RMUD.Direction.EAST, "blecki-demo/shoreline");
		OpenLink(RMUD.Direction.FORE, "blecki-demo/cabin");
	}
}
