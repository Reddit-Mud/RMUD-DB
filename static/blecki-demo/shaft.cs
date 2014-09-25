public class shaft : RMUD.Room
{
    public override void Initialize()
    {
        Short = "Inside the dark shaft";
        Long = "The shaft can be traversed by way of a rusted ladder, if the climber is brave enough. The shaft is round. Above is a small circle of light, and below nothing but darkness. Here and there a name sits proudly carved into the masonry, or a date, occasionally both. Rusty tacks hold a set of mouldy wires to the side of the shaft.";

        OpenLink(RMUD.Direction.UP, "blecki-demo/lighthouse_balcony");
        OpenLink(RMUD.Direction.DOWN, "blecki-demo/pit");
    }
}
