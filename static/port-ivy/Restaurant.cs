//import scenery_lamp

public class Restaurant: RMUD.Room
{
    public override void Initialize() {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Restaurant";
        Long = "The large mirror behind the bar rules over the room. Three rows of various liquors and alcohol spike up below it. The bar has three beer taps and a number of bar stools. Round tables wrapped by four chairs are disseminated throughout the room, covered by red-and-white checkered tablecloths.";

        AddScenery(new scenery_lamp("wall lamps", "The lamps, regularly spaced, project their lights up towards the white coat of paint of the ceiling, where it is reflected and provides the adequate lighting for a bar, and just a little less than one would expect for a restaurant."));

      OpenLink(RMUD.Direction.EAST, "port-ivy/Main_St_South_0");
      OpenLink(RMUD.Direction.WEST, "port-ivy/Docks_2");
    }
}
