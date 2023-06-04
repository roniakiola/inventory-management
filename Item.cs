public class Item
{
  private string _barcode;
  private string _name;
  private int _quantity;

  public Item(string _barcode, string _name, int _quantity)
  {
    this._barcode = _barcode;
    this._name = _name;
    this._quantity = _quantity;
  }

  public void IncreaseQuantity(int amount)
  {
    if (amount > 0)
    {
      _quantity += amount;
    }
  }
  public void DecreaseQuantity(int amount)
  {
    if (amount > 0 && _quantity > amount)
    {
      _quantity -= amount;
    }
  }
  public string Barcode
  {
    get { return _barcode; }
  }

  public string Name
  {
    get { return _name; }
  }

  public int Quantity
  {
    get { return _quantity; }
  }
}