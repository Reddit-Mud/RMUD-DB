//Generated by rmud area generator
public class Main_St_North_1 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Main St North";

      OpenLink(RMUD.Direction.NORTH, "port-ivy/Main_St_North_0");
      OpenLink(RMUD.Direction.SOUTH, "port-ivy/Main_St_North_2");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Thornton_Heights_0");
    }
}