//Generated by rmud area generator
public class Waterfront_Park_1 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Waterfront Park";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Waterfront_Park_2");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Waterfront_Park_0");
    }
}
