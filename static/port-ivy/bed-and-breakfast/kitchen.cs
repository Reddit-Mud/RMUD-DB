//import window
//import scenery_lamp

class kitchen : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Kitchen";
        Long = "The kitchen is dirty, and dingy, and other adjectives that mean the same thing. It is bathed in the slightly blue tint of old florescent lighting, with just enough flicker to make your eyes hurt. A small window looks out over the beach.";

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/patio");
        OpenLink(RMUD.Direction.EAST, "port-ivy/bed-and-breakfast/sitting_room");
        
        AddScenery(new window("small window", "port-ivy/beach_1"));
        AddScenery(new scenery_lamp("overhead lights", "These ugly florescent lights flicker overhead. They get the job done, in the sense that you can see, but darkness would likely be preferable."));
    }
}

