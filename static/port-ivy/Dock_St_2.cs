//Generated by rmud area generator
public class Dock_St_2 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Dock St";

      OpenLink(RMUD.Direction.SOUTHEAST, "port-ivy/Dock_St_4");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Crescent_and_Dock");
    }
}
