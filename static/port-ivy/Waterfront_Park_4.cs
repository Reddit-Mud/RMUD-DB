//Generated by rmud area generator
public class Waterfront_Park_4 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Waterfront Park";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Tide_Crush_Bluffs_2");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Waterfront_Park_3");
    }
}
