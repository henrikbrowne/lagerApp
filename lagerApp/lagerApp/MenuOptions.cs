namespace lagerApp;

public class MenuOptions
{
    public List<MenuOption> MainMenuOptions { get; } =
    [
        new("Prosesser ordrefil", 1),
        new("Se rapporter", 2),
        new("Avslutt programmet", 3)
    ];

    public List<MenuOption> RapporterOptions { get; } =
    [
        new("Lagerbeholdning", 1),
        new("Ordrestatus", 2),
        new("Leverandørrapport", 3)
    ];
}