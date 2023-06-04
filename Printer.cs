public class Printer
{
  public void PrintItem(Item item)
  {
    Console.WriteLine($"Name: {item.Name}, Barcode: {item.Barcode}");
  }
  public void PrintInventory(Inventory inventory)
  {
    int uniqueItems = inventory.items.Count;
    int totalItems = 0;

    foreach (var item in inventory.items)
    {
      totalItems += item.Value.Quantity;
    }
    Console.WriteLine($"Unique Items: {uniqueItems}, Total Items: {totalItems}");
  }
}