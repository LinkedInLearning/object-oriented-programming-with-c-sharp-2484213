using System.Text;

namespace OOPAdventure;

public class Room : IInventory
{

    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    private readonly IInventory _invnetory = new Inventory();

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.East, -1 },
        {Directions.South, -1 },
        {Directions.West, -1 },
        {Directions.None, -1 },

    };

    public bool Visited { get; set; }

    public int Total => _invnetory.Total;

    public string[] InventoryList => _invnetory.InventoryList;

    public override string ToString()
    {

        var sb = new StringBuilder();

        if (Visited)
            sb.Append(string.Format(Text.Language.RoomOld, Name));
        else
            sb.Append(string.Format(Text.Language.RoomNew, Name));

        var names = Enum.GetNames(typeof(Directions));

        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

        sb.Append(description);


        if(_invnetory.Total > 0)
        {

            var items = _invnetory.InventoryList;

            var pluralPre = items.Length > 1 ? Text.Language.Are : Text.Language.Is;

            var pluralPost = items.Length > 1 ? Text.Language.Plural : "";

            sb.Append(string.Format(Text.Language.TotalItems, pluralPre, items.Length, pluralPost));

            sb.Append(Text.Language.JoinedWordList(items, Text.Language.And) + Text.Language.Period);

        }


        return sb.ToString();

    }

    public void Add(Item item)
    {
        _invnetory.Add(item);
    }

    public bool Conatins(string itemName)
    {
        return _invnetory.Conatins(itemName);
    }

    public Item? Find(string itemName)
    {
        return _invnetory.Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return _invnetory.Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        _invnetory.Remove(item);
    }

    public Item? Take(string itemName)
    {
        return _invnetory.Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        _invnetory.Use(itemName, source);
    }
}