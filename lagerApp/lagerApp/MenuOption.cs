namespace lagerApp;

public class MenuOption
{
    public string Description { get; }
    public int Id { get; }
    public Action? Callback { get; }

    public MenuOption(string description, int id, Action? callback = null)
    {
        Description = description;
        Id = id;
        Callback = callback;
    }
}