using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg22
{
    public class Item
    {
        public string name;
        public int price;

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
