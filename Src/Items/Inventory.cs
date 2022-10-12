using OOPAdventure;

public class Inventory
{

    private List<Item> Items { get; } = new();

    public int Total => Items.Count;

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }
}