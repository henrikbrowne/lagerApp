namespace lagerApp;

public class Warehouse
{
    private Inventory inventory { get; set; } = new();
    private List<Order> orders { get; set; } = [];
    
    
    public void ShowInventory()
    {
        Console.WriteLine("Lagerbeholdning:");
        foreach (var key in inventory.Items.Keys)
        {
            Console.WriteLine($"{key}: {inventory.Items[key]}");
        }
    }

    public void ShowOrderStatus()
    {
        Console.WriteLine("Ordre:");
        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"{orders[i]}: Fullført!");
            //TODO: Skriv plukkrapport
        }
    }

    public void ShowSupplierReport()
    {
        Console.WriteLine("Showing supplier report...");
    }
}