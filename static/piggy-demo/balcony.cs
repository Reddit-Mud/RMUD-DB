public class balcony : RMUD.Room
{
	public override void Initialize()
	{

		Short = "Lantern Room and Balcony";
		Long = "The huge [lantern] sits unused, yet its mirrors and prisms are clean and in excellent condition, indicating that someone still cares for this lighthouse, despite it's heart no longer beating. It sits as a guardian monument, ever watching the waters for passing ships, waiting to be revived for nostalgic ceremony. A vast swath of the ocean is visable from up here, as is most of the island. There is a quaint, smartly kept residence to the north, and a small town beyond that, yet the expanse of open sea tugs at your attentions, offering infinite possibilities with open arms.";

		OpenLink(RMUD.Direction.DOWN, "piggy-demo/stairwell");

		AddScenery("it sits on a pedestal with a variety of strangely shaped prisms. There is writing on the base but you are unable to read it. It looks as though the glyphs were scratched into the metal housing. The lamp inside the glass resembles a cat's iris.", "lantern");
	}
}
