//Generated by rmud area generator
public class Dock_St_3 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Dock St";

      OpenLink(RMUD.Direction.NORTHEAST, "port-ivy/Dock_St_0");
      OpenLink(RMUD.Direction.SOUTHEAST, "port-ivy/Chamber_of_Commerce");
      OpenLink(RMUD.Direction.SOUTHWEST, "port-ivy/Dock_St_7");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Forest_5");
    }
}
