namespace lagerApp;

public class Item
{
    private string shelf;
    public ItemType? itemType;

    public Item(string shelf, ItemType? itemType)
    {
        this.shelf = shelf;
        this.itemType = itemType;
    }
}