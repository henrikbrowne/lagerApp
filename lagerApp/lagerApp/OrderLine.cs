namespace lagerApp;

public record OrderLine
(
    ItemType? itemType,
    string shelf,
    int? quantity
);