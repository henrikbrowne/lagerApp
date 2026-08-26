namespace lagerApp;

public class Warehouse
{
    public Inventory Inventory { get; set; } = new();
    private List<Order> Orders { get; set; } = [];
    
    
    public void ShowInventory()
    {
        Console.WriteLine("Lagerbeholdning:");
        foreach (var key in Inventory.Items.Keys)
        {
            Console.WriteLine($"{key}: {Inventory.Items[key].Count}");
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
        Console.WriteLine("Leverandørrapport:");
        foreach (var key in Inventory.SupplierOrders.Keys)
        {
            Console.WriteLine($"{key}: {Inventory.SupplierOrders[key]}");
        }
    }
    
}