namespace lagerApp;

public class Item(string shelf, ItemType? itemType)
{
    private string shelf = shelf;
    private ItemType? itemType = itemType;
}