namespace lagerApp;

public class Warehouse
{
    public Inventory Inventory { get; set; } = new();
    private List<Order> Orders { get; set; } = [];

    public void InsertItems(List<Item> newItems)
    {
        foreach (Item itemObj in newItems)
        {
            Inventory.Items[(ItemType) itemObj.itemType].Add(itemObj);
        }
    }
    
    public void ShowInventory()
    {
        Console.WriteLine("Lagerbeholdning:");
        foreach (var key in Inventory.Items.Keys)
        {
            Console.WriteLine($"{key}: {Inventory.Items[key]}");
        }
    }

    public void ShowOrderStatus()
    {
        Console.WriteLine("Ordre:");
        for (int i = 0; i < Orders.Count; i++)
        {
            Console.WriteLine($"{Orders[i]}: Fullført!");
            //TODO: Skriv plukkrapport
        }
    }

    public void ShowSupplierReport()
    {
        Console.WriteLine("Showing supplier report...");
    }
}