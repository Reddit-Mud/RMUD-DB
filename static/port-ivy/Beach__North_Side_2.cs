//Generated by rmud area generator
public class Beach__North_Side_2 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Beach, North Side";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Beach__North_Side_3");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Shipwreck");
    }
}