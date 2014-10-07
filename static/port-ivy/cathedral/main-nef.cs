public class main-nef: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The main nef";
        Long = "Benches everywhere and not a soul in sight. The light from the stained-glass windows illustrates the desolation of such an empty gathering house. The altar is made of white marble. Behind the altar, a crucified Jesus hangs, paying for the sins of mankind. Exits lead to the north and south nefs, and an exit behind the altar leads to the cemetery.";

        Openlink(RMUD.Direction.NORTH, "port-ivy/cathedral/north-side-nef");
        Openlink(RMUD.Direction.SOUTH, "port-ivy/cathedral/south-side-nef");
        Openlink(RMUD.Direction.EAST, "port-ivy/cathedral/cemetery");
    }
}
