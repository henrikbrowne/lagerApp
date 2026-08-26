namespace lagerApp;

public record OrderLine
(
    ItemType? itemType,
    int? quantity
);