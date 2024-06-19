using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
using TeslaCoffeeShop.UI;

namespace TeslaCoffeeShop.BL
{
    class menuItem
    {
        private string name;
        private string type;
        private int price;

        public menuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
