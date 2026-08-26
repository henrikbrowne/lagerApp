using System.Reflection;

namespace lagerApp;

public class OrderReader: IReader
{
    public Order? ReadOrderCsv(string filePath)
    {
        // Use the IncomingOrder.csv
        List<string[]> orderLines = IReader.ReadCsvLines(filePath);
    
        // Split the file using simple syntax

        string[]? orderHeader = orderLines.FirstOrDefault();
        
        if (orderHeader is not null)
        {
            List<OrderLine> orderItems = orderLines.Skip(1).Select(o => new
                {
                    Item = ReturnItemAsAction(o[0]),
                    Quantity = GetQuantityAsAction(o[1])
                })
                .Where(x => x.Item is not null && x.Quantity is not null)
                .Select(o => new OrderLine(o.Item,o.Quantity)) 
                .ToList();
            return new Order(orderItems);
        }

        return null;
    }

    public List<Item> ReadInventoryCsv(string filePath)
    {
        // Use the IncomingOrder.csv
        List<string[]> orderLines = IReader.ReadCsvLines(filePath);
    
        // Split the file using simple syntax

        string[]? orderHeader = orderLines.FirstOrDefault();
        
        if (orderHeader is not null)
        {
            List<Item> orderItems = orderLines.Skip(1).Select(o => new
                {
                    Item = ReturnItemAsAction(o[0]),
                    Quantity = GetQuantityAsAction(o[1]),
                    shelf = o[2]
                })
                .Where(x => x.Item is not null && x.Quantity is not null)
                .SelectMany(
                    x => Enumerable.Range(0, x.Quantity.Value),
                    (x, _) =>new Item(x.shelf, x.Item)) 
                .ToList();
            return orderItems;
        }

        return null;
    }

    public ItemType? ReturnItemAsAction(string lineValue)
    {
        if (Enum.TryParse(lineValue, true, out ItemType result))
        {
            return result;
        }

        return null;
    }

    public int? GetQuantityAsAction(string lineValue)
    {
        int result;
        if (Int32.TryParse(lineValue, out result))
        {
            return result;
        }

        return null;
    }
}