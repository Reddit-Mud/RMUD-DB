//Generated by rmud area generator
public class _08_14 : RMUD.Room {
    public override void Initialize() {
        Short = "Port Ivy - Dock St";

        OpenLink(RMUD.Direction.NORTH, "port-ivy/_08_12");
        OpenLink(RMUD.Direction.EAST, "port-ivy/_10_14");
        OpenLink(RMUD.Direction.WEST, "port-ivy/_06_14");
    }
}
