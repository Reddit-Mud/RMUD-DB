//Generated by rmud area generator
public class Forest_4 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Forest";

      OpenLink(RMUD.Direction.NORTHEAST, "port-ivy/Forest_1");
      OpenLink(RMUD.Direction.SOUTH, "port-ivy/Forest_5");
    }
}
