class bay_room_door : RMUD.BasicDoor
{
    public override void Initialize()
    {
        Short = "door";
        Long = "An ordinary sort of door. It's good at being opaque.";
        Nouns.Add("bay", "room");
    }
}
