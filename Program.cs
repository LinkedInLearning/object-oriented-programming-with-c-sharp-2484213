using OOPAdventure;

Console.WriteLine("Hello, what is your name?");

var name = Console.ReadLine();

if (name == String.Empty)
    name = "No Name";

var player = new Player(name);

Console.WriteLine("Welcome {0} to your OOP Adventure!", player.Name);