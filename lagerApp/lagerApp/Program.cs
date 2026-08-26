namespace lagerApp;

class Program
{
    static void Main()
    {
        Warehouse warehouse = new();
        OrderReader orderReader = new();
        LagerUI lagerUi = new(warehouse, orderReader);
        lagerUi.Run();
    }
}