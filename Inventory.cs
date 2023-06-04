public class Inventory
{
  private static Inventory instance;
  public Dictionary<string, Item> items;
  public int maxCapacity;

  private Inventory(int maxCapacity)
  {
    items = new Dictionary<string, Item>();
    this.maxCapacity = maxCapacity;
  }

  public static Inventory Instance
  {
    get
    {
      if (instance == null)
      {
        instance = new Inventory(10);
      }
      return instance;
    }
  }

  public bool AddItem(Item item, int quantity)
  {
    if (quantity <= 0)
    {
      return false;
    }
    if (items.ContainsKey(item.Barcode))
    {
      items[item.Barcode].IncreaseQuantity(quantity);
    }
    else if (items.Count < maxCapacity)
    {
      item.IncreaseQuantity(quantity);
      items.Add(item.Barcode, item);
    }
    else
    {
      return false;
    }
    return true;
  }

  public bool RemoveItem(string barcode)
  {
    if (!items.ContainsKey(barcode))
    {
      return false;
    }
    items.Remove(barcode);
    return true;
  }

  public void IncreaseQuantity(int amount, string barcode)
  {
    if (items.ContainsKey(barcode))
    {
      items[barcode].IncreaseQuantity(amount);
    }
  }

  public void DecreaseQuantity(int amount, string barcode)
  {
    if (items.ContainsKey(barcode))
    {
      items[barcode].DecreaseQuantity(amount);
    }
  }

  public void ViewInventory()
  {
    foreach (Item item in items.Values)
    {
      Console.WriteLine($"Barcode: {item.Barcode}, Name: {item.Name}, Quantity: {item.Quantity}");
    }
  }

  ~Inventory()
  {
    Console.WriteLine("Inventory destroyed.");
  }
}