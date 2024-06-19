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
    class coffeeShop
    {
        private string name;
        static public List<menuItem> menu = new List<menuItem>();

        public coffeeShop(string name)
        {
            this.name = name;
        }

        public string cheapestItem()
        {
            int cheapest = 10000000;
            int idx=0;
            for (int x = 0; x < menu.Count; x++ )
            {
                if (menu[x].getPrice() < cheapest)
                {
                    cheapest = menu[x].getPrice();
                    idx = x;
                }
            }
            return menu[idx].getName();
        }

        public List<menuItem> drinksOnly()
        {
            foreach (menuItem m in menu)
            {
                if (m.getType() == "Drink")
                {
                    coffeeShopDL.drinksOnlyList.Add(m);
                }
            }
            return coffeeShopDL.drinksOnlyList; 
        }

        public List<menuItem> foodOnly()
        {
            foreach (menuItem m in menu)
            {
                if (m.getType() == "Food")
                {
                    coffeeShopDL.foodOnlyList.Add(m);
                }
            }
            return coffeeShopDL.foodOnlyList;
        }
        
        public bool addOrder(string name)
        {
            bool flag = false;
            foreach (menuItem m in menu)
            {
                if (name == m.getName())
                {
                    coffeeShopDL.ordersList.Add(name);
                    flag = true;
                }
            }

            if (flag == true )
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public string fullfillOrder()
        {
            if (coffeeShopDL.ordersList == null)
            {
                return "All orders has been fulfilled";
            }
            else
            {
                for(int x = 0; x < coffeeShopDL.ordersList.Count; x++)
                {
                    coffeeShopDL.orderTaken.Add(coffeeShopDL.ordersList[x]);
                }
                coffeeShopDL.ordersList.Clear();
                return "The Items are Ready";
            }
        }

        public List<string> takenOrders()
        {
            if (coffeeShopDL.orderTaken == null)
            {
                return null;
            }
            else
            {
                return coffeeShopDL.orderTaken;
            }
        }

        public int dueAmount()
        {
            int amount = 0;
            foreach(string m in coffeeShopDL.orderTaken)
            {
                foreach(menuItem i in menu)
                {
                    if ( m == i.getName())
                    {
                        amount = amount + i.getPrice();
                    }
                }
            }
            return amount;
        }
    }
}
