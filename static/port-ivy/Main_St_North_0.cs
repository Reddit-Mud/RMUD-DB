//Generated by rmud area generator
public class Main_St_North_0 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Main St North";

      OpenLink(RMUD.Direction.NORTHEAST, "port-ivy/Shipwreck");
      OpenLink(RMUD.Direction.EAST, "port-ivy/Cathedral");
      OpenLink(RMUD.Direction.SOUTH, "port-ivy/Main_St_North_1");
      OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/porch");
    }
}
