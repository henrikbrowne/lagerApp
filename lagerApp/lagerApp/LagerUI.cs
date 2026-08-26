namespace lagerApp;

public class LagerUI
{
    private readonly MenuOptions menuOptions = new();

    public void Run()
    {
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        List<MenuOption> options =
        [
            new("Prosesser ordrefil", 1, ProcessOrderFile),
            new("Se rapporter", 2, ShowReports),
            new("Avslutt programmet", 3, Exit)
        ];

        GetInput(options);
    }

    private void ShowReports()
    {
        List<MenuOption> options =
        [
            new("Lagerbeholdning", 1, ShowInventory),
            new("Ordrestatus", 2, ShowOrderStatus),
            new("Leverandørrapport", 3, ShowSupplierReport)
        ];

        GetInput(options, "Velg rapport");
    }

    private void GetInput(List<MenuOption> options, string? prompt = null)
    {
        while (true)
        {
            if (prompt != null)
                Console.WriteLine(prompt);

            for (int i = 0; i < options.Count; i++)
                Console.WriteLine($"{i + 1}. {options[i].Description}");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int response) &&
                response >= 1 &&
                response <= options.Count)
            {
                options[response - 1].Callback?.Invoke();
                return;
            }

            Console.WriteLine("Error: Plz enter valid response :(");
        }
    }

    private void ProcessOrderFile()
    {
        Console.WriteLine("Processing order file...");
    }

    private void ShowInventory()
    {
        Console.WriteLine("Showing inventory...");
    }

    private void ShowOrderStatus()
    {
        Console.WriteLine("Showing order status...");
    }

    private void ShowSupplierReport()
    {
        Console.WriteLine("Showing supplier report...");
    }

    private void Exit()
    {
        Console.WriteLine("Goodbye!");
    }
}