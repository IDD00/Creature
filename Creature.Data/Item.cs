using System;
using System.Collections.Generic;
using System.Text;

namespace Creature.Data
{
    public class Item
    {
        public Item(string name)
        {
            ItemName = name;
            Quantity = 1;
            Price = 10;
        }

        public Item(string name, int quantity, int price)
        {
            ItemName = name;
            Quantity = quantity;
            Price = price;
        }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public override string ToString() => ItemName;
    }
}
