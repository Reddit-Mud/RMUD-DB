//Generated by rmud area generator
public class Main_St_South_0 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Main St South";

      OpenLink(RMUD.Direction.EAST, "port-ivy/Antique_Mall");
      OpenLink(RMUD.Direction.SOUTHEAST, "port-ivy/Main_St_South_1");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Restuarant");
      OpenLink(RMUD.Direction.NORTHWEST, "port-ivy/Main_and_Dock");
    }
}