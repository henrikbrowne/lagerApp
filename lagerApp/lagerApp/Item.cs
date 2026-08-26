namespace lagerApp;

public class Item(string shelf, ItemType? itemType)
{
    private string shelf = shelf;
    public ItemType? itemType = itemType;
}