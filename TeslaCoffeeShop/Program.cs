using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
using TeslaCoffeeShop.UI;

namespace TeslaCoffeeShop
{
    class Program
    {
        static public coffeeShop shop = new coffeeShop("Teasla Coffee Shop");
        static void Main(string[] args)
        {
            string filePath = "menuInfo.txt";
            if (coffeeShopDL.readFromFile(filePath))
            {
                Console.WriteLine("Ships Data Loaded Successfully");
            }
            menuUI.clear();
            int option = 0;
            while (option != 9)
            {
                option = menuUI.menu();
                menuUI.clear();
                if (option == 1)
                {
                    menuItem m = menuItemUI.getMenuInfo();
                    coffeeShopDL.addMenuItem(m);
                    coffeeShopDL.storeMenu(filePath, m);
                    menuUI.clear();
                }
                else if (option == 2)
                {
                    coffeeShopUI.cheapest();
                    menuUI.clear();
                }
                else if (option == 3)
                {
                    coffeeShopUI.drinksOnly();
                    menuUI.clear();
                }
                else if (option == 4)
                {
                    coffeeShopUI.foodOnly();
                    menuUI.clear();
                }
                else if (option == 5)
                {
                    coffeeShopUI.takeOrder();
                    menuUI.clear();
                }
                else if (option == 6)
                {
                    coffeeShopUI.fullfillOrder();
                    shop.fullfillOrder();
                    menuUI.clear();
                }
                else if (option == 7)
                {
                    shop.takenOrders();
                    coffeeShopUI.listOrders();
                    menuUI.clear();
                }
                else if (option == 8)
                {
                    int total = shop.dueAmount();
                    coffeeShopUI.totalAmount(total);
                    menuUI.clear();
                }
            }
        }  
    }
}
