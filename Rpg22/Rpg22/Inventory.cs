using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22
{
    public class Inventory
    {
        public List<Item> list;

        public Inventory()
        {
            list = new List<Item>();
        }

        public void AddItem(Item item)
        {
            list.Add(item);
        }

        public void PrintInventory()
        {
            foreach (Item item in list) 
            { 
                Console.WriteLine(item.name);
            }
        }

    }
}
