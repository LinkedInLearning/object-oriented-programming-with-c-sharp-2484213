using OOPAdventure;

var language = new English();

Console.WriteLine(language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)
    name = "No Name";

var player = new Player(name);

Console.WriteLine("Welcome {0} to your OOP Adventure!", player.Name);