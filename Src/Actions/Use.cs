namespace OOPAdventure;

public class Use : Action
{

    private readonly House _house;

    public Use(House house)
    {

        _house = house;

    }

    public override string Name => Text.Language.Use;

    public override void Execute(string[] args)
    {

        if(args.Length < 1)
        {

            Console.WriteLine(Text.Language.UseError);

            return;

        }

        var itemName = args[1];

        if(_house.Player.Conatins(itemName))
        {

            var item = _house.Player.Take(itemName);

            Console.WriteLine(Text.Language.UseSuccess, item.Name);

            item.Use(itemName);

        }
        else
        {

            Console.WriteLine(Text.Language.UseError);

        }

    }

}