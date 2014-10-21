public class Main_St_South_1 : RMUD.Room {
    public override void Initialize() {
        RoomType = RMUD.RoomType.Exterior;
        Short = "The South end of Main Street";
        Long = "Main Street goes Northwest from here, while to the East it becomes Crescent Street. To the west, a stone arch with an oxidized bronze plaque stands here in guise of invitation to visit the Waterfront Park.";

      AddScenery("The plaque's writing is hard to decipher, but thanks a Lord Stanner for a donation. A faint engraving of a once proud profile is next to the words.", "plaque", "bronze plaque", "oxidized bronze plaque");

      OpenLink(RMUD.Direction.EAST, "port-ivy/Crescent_St_Southwest_1");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Waterfront_Park_2");
      OpenLink(RMUD.Direction.NORTHWEST, "port-ivy/Main_St_South_0");
    }
}
