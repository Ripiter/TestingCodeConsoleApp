using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class Inventory
    {

        private List<Item> items = new List<Item>();

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        

        public void AddItemToList(Item item)
        {
            Items.Add(item);
        }
    }
}
