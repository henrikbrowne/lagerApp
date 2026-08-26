namespace lagerApp;

class Program
{
    static void Main()
    {
        Warehouse warehouse = new();
        OrderReader orderReader = new();
        
        List<Item> wareHouseItems = orderReader.ReadInventoryCsv("LagerBeholdning.csv");
        
        warehouse.InsertItems(wareHouseItems);
        
        LagerUI lagerUi = new(warehouse, orderReader);
        lagerUi.Run();
    }
}