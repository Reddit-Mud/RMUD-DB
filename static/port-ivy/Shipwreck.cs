//Generated by rmud area generator
public class Shipwreck : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Shipwreck";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Beach__North_Side_2");
      OpenLink(RMUD.Direction.SOUTHWEST, "port-ivy/Main_St_North_0");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Beach__North_Side_1");
    }
}
