//Generated by rmud area generator
public class Crescent_St_Southwest_0 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Crescent St Southwest";

      OpenLink(RMUD.Direction.NORTHEAST, "port-ivy/Crescent_St_2");
      OpenLink(RMUD.Direction.EAST, "port-ivy/School");
      OpenLink(RMUD.Direction.SOUTHWEST, "port-ivy/Crescent_St_Southwest_2");
    }
}
