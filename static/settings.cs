﻿public class settings : RMUD.Settings
{
    public override void Initialize()
    {
        Banner = "~~== REDDIT MUD ==~~\r\n";
        MessageOfTheDay = "register username password - Create a new account.\r\nlogin username password - Log into an existing account.";
        NewPlayerStartRoom = "port-ivy/Main_St_South_1";
        UpfrontCompilation = true;
    }
}