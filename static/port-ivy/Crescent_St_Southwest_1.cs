//Generated by rmud area generator
public class Crescent_St_Southwest_1 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Crescent St Southwest";

      OpenLink(RMUD.Direction.NORTH, "port-ivy/Monument");
      OpenLink(RMUD.Direction.EAST, "port-ivy/Crescent_St_Southwest_2");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Main_St_South_1");
    }
}
