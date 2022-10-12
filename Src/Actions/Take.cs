namespace OOPAdventure;

public class Take : Action
{

    private readonly House _house;

    public Take(House house)
    {

        _house = house;

    }

    public override string Name => Text.Language.Take;

    public override void Execute(string[] args)
    {

        if(args.Length == 1)
        {

            Console.WriteLine(Text.Language.NotTaken);

            return;

        }

        var inventory = _house.CurrentRoom;

        var itemName = args[1].ToLower();

        if(inventory.Conatins(itemName))
        {

            var item = inventory.Take(itemName);

            if(item.CanTake)
            {

                _house.Player.Add(item);

                Console.WriteLine(Text.Language.TookDescription, item.Name);

            }
            else
            {

                Console.WriteLine(Text.Language.CantTakeDescription, item.Name);

            }

            return;

        }

        Console.WriteLine(Text.Language.TakeError);

    }

}