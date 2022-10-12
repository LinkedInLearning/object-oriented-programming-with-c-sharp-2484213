using OOPAdventure;

public class English :Language
{

    public English()
    {

        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome {0} to your OOP Adventure!";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You return to {0}.";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange"
        };
    }

}