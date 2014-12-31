class captain_jacks_room : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Captain Jack's Room";
        Long = "This room is named for Captain Jack. It has pinstripe wallpaper and deep purple carpet. Apparently Captain Jack was known for having terrible taste.";

        AddScenery("The stripes are pink on blue.", "pinstripe", "wallpaper");
        AddScenery("It's actually mostly a sort of dirty purple.", "carpet");

        OpenLink(RMUD.Direction.SOUTH, "port-ivy/bed-and-breakfast/hallway", GetObject("port-ivy/bed-and-breakfast/jacks_door"));
        
    }
}

