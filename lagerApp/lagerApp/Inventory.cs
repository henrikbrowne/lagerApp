namespace lagerApp;

public class Inventory
{
    public Dictionary<ItemType, List<Item>> Items { get; } = new();
}