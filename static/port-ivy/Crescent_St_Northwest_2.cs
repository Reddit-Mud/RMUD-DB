//Generated by rmud area generator
public class Crescent_St_Northwest_2 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Crescent St Northwest";

      OpenLink(RMUD.Direction.NORTH, "port-ivy/House_02");
      OpenLink(RMUD.Direction.EAST, "port-ivy/Crescent_St_Northwest_3");
      OpenLink(RMUD.Direction.SOUTHEAST, "port-ivy/Forest_2");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Crescent_St_Northwest_1");
    }
}