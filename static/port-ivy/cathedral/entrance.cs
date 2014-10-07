public class entrance: RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RoomType.Interior;
        Short = "The entrance to the cathedral";
        Long = "The semidarkness of the cathedral weighs heavily. One one side of the door, a few melted candles illuminate three pamphlets sitting in their wooden container. On the other side, the granite wall shows off its grotesque gargoyle guardian. By the pillar near the entrance of the nef, the stoup holds the holy water. There is very little water in the stoup. There are paths north and south to each side paths and east to the main nef, towards the altar.";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/cathedral/north-side-nef");
        OpenLink(RMUD.Direction.SOUTH, "port-ivy/cathedral/south-side-nef");
        OpenLink(RMUD.Direction.EAST, "port-ivy/cathedral/main-nef");

        AddScenery("The candles are lit by people who make a prayer. It is hard to guess just how long ago the last candle was lit.", "candle", "candles");
        AddScenery("The walls are made of granite. Upon closer examination, the wall near the main door reveals being ever-so-slightly above the floor", "wall", "walls");
        AddScenery("The gargoyle stares out at the passerbys with a mocking rictus. One of the ears is smoother and cleaner than the other.", "gargoyle", "guardian");
        AddScenery("The stoup holds sadly the holy water. It is hard to tell if it is drying because no one replenishes it or if it is intended to hold so little.", "stoup");
    }
}
