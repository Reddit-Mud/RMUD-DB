//Generated by rmud area generator
public class Main_St_North_5 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Main St North";

      OpenLink(RMUD.Direction.NORTH, "port-ivy/Main_St_North_4");
      OpenLink(RMUD.Direction.SOUTH, "port-ivy/Main_and_Dock");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Bookstore");
    }
}
