using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
using TeslaCoffeeShop.UI;

namespace TeslaCoffeeShop.UI
{
    class coffeeShopUI
    {
        static public void cheapest()
        {
            Console.WriteLine("The cheapest Item in the Menu is " + Program.shop.cheapestItem());
        }

        static public void drinksOnly()
        {
            Program.shop.drinksOnly();
            Console.WriteLine("List of Items on Menu that are Drinks:");
            foreach (menuItem m in coffeeShopDL.drinksOnlyList)
            {
                if (m.getType() == "Drink")
                {
                    Console.WriteLine(m.getName());
                }
            }
        }

        static public void foodOnly()
        {
            Program.shop.foodOnly();
            Console.WriteLine("List of Items on Menu that are in Food:");
            foreach (menuItem m in coffeeShop.menu)
            {
                if (m.getType() == "Food")
                {
                    Console.WriteLine(m.getName());
                }
            }
        }

        static public void takeOrder()
        {
            Console.Write("Enter the Name of the Order = ");
            string name = Console.ReadLine();
            bool flag = false;
            flag = Program.shop.addOrder(name);
            if (flag == true)
            {

                Console.WriteLine("Your Order has been taken.");
            }
            else
            {
                Console.WriteLine("This Item is currently unavailable.");
            }
        }

        static public void fullfillOrder()
        {
            Console.WriteLine("List of Orders Fulfilled");
            foreach (string m in coffeeShopDL.ordersList)
            {
                Console.WriteLine(m);
            }
        }

        static public void listOrders()
        {
            Console.WriteLine("List of Orders Taken");
            foreach (string m in coffeeShopDL.orderTaken)
            {
                Console.WriteLine(m);
            }
        }

        static public void totalAmount(int t)
        {
            Console.WriteLine("Total Amount is = " + t);
        }
    }
}
