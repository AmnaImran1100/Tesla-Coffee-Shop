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
    class menuItemUI
    {
        static public menuItem getMenuInfo()
        {
            Console.WriteLine("Enter Name = ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Type = ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Price = ");
            int price = int.Parse(Console.ReadLine());

            menuItem m = new menuItem(name, type, price);
            return m;
        }
    }
}
