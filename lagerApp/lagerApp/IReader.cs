using System.Reflection;

namespace lagerApp;

public interface IReader
{
    static List<string[]> ReadCsvLines(string filePath)
    {
        string directory = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location) ?? "";

        string fullPath = Path.Combine(directory, filePath);
        
        string[] fileItems =  File.ReadAllLines(fullPath);
        
        List<string[]> orderItems = fileItems.Select(s =>
            s.Split(",")).ToList();

        return orderItems;
    }
}