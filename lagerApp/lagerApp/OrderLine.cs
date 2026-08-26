namespace lagerApp;

public record OrderLine
{
    ItemType itemType;
    private string shelf;
    int quantity;
}