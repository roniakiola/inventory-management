Inventory inventory = Inventory.Instance;
Printer printer = new Printer();

Item item1 = new Item("asd", "Item asd", 5);
Item item2 = new Item("qwe", "Item qwe", 10);
Item item3 = new Item("zxc", "Item zxc", 3);

inventory.AddItem(item1, 2);
inventory.AddItem(item1, 0); //false addition test
inventory.AddItem(item2, 5);
inventory.AddItem(item3, 1);

inventory.ViewInventory();

inventory.IncreaseQuantity(2, "asd");
inventory.DecreaseQuantity(7, "qwe");

inventory.ViewInventory();

printer.PrintItem(item1);
printer.PrintInventory(inventory);