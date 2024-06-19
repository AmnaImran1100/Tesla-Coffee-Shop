using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.UI
{
    class menuUI
    {
        static public int menu()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("*            TEASLA COFFEE SHOP            *");
            Console.WriteLine("********************************************");
            Console.WriteLine("1. ADD a Menu Item");
            Console.WriteLine("2. View the Cheapest Item in the Menu");
            Console.WriteLine("3. View the Drink's Menu");
            Console.WriteLine("4. View Foods Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fullfill the Order");
            Console.WriteLine("7. View the Orders Taken");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your Option = ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static public void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
