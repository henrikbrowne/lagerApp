namespace lagerApp;

public class Inventory
{
    public Dictionary<ItemType, List<Item>> Items { get; } =
        Enum.GetValues<ItemType>()
            .ToDictionary(type => type, _ => new List<Item>());
    
    public Dictionary<ItemType, int> SupplierOrders { get; } = 
        Enum.GetValues<ItemType>()
            .ToDictionary(type => type, _ => 0);

    public void ProcessOrderLine(OrderLine orderLine)
    {
        for (int i = 0; i < orderLine.quantity; i++)
        {
            if (orderLine.itemType == null)
            {
                continue;
            }
            List<Item> bucket = Items[(ItemType)orderLine.itemType];

            if (bucket.Count == 0)
            {
                Console.WriteLine("IKKE NOK " + orderLine.itemType);
            }
            else
            {
                bucket.RemoveAt(bucket.Count - 1);
                Console.WriteLine("Processed order item");
            }
        }
    }

    private int GetMinimumQuantity(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Laptop:
                return 5;
            default:
                return 10;
                
        }
    }

    public void RefillFromSupplier()
    {
        foreach (var key in Items.Keys)
        {
            int weHave = Items[key].Count;
            int weShouldHave = GetMinimumQuantity(key);
            int surplus = weHave - weShouldHave;
            if (surplus < 0)
            {
                PlaceSupplierOrder(-surplus, key);
            }
        }
    }

    private void PlaceSupplierOrder(int quantity, ItemType itemType)
    {
        if (SupplierOrders.ContainsKey(itemType))
        {
            SupplierOrders[itemType] += quantity;
        }
        else
        {
            SupplierOrders.Add(itemType, quantity);
        }
    }
}