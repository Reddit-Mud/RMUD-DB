//import scenery_lamp
//import window

class henrietta_wok_room : RMUD.Room
{
    public override void Initialize()
    {
        RoomType = RMUD.RoomType.Interior;
        Short = "Port Ivy - Bed and Breakfast - Henrietta Wok Room";
        Long = "This room is named after the woman who hung herself in it. The plague on the door says so. The rafters are exposed here, thick wooden beams with the sloped roof above. It would not have been very challenging to hang herself from them. A queen size bed takes up most of the room, crouching below a single small window. An ornate lamp sits beside the bed.";

        OpenLink(RMUD.Direction.WEST, "port-ivy/bed-and-breakfast/landing", GetObject("port-ivy/bed-and-breakfast/wok_door"));

        AddScenery(new window("small window", "port-ivy/Main_St_North_0"));
        AddScenery(new scenery_lamp("ornate lamp", "This old lamp is covered in little metal leaves. The corners look quite sharp."));
    }
}

