//Generated by rmud area generator
public class Dock_St_1 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Dock St";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Crescent_and_Dock");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Dock_St_0");
    }
}
