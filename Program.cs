Inventory inventory = Inventory.Instance;

Item item1 = new Item("asd", "Item 1", 5);
Item item2 = new Item("qwe", "Item 2", 10);
Item item3 = new Item("zxc", "Item 3", 3);
Item item4 = new Item("asd", "Item 4", 15);

inventory.AddItem(item1, 2);
inventory.AddItem(item2, 5);
inventory.AddItem(item3, 1);
inventory.AddItem(item4, 1);
inventory.AddItem(item1, 0);

inventory.ViewInventory();