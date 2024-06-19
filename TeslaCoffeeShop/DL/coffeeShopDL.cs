using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
using TeslaCoffeeShop.UI;


namespace TeslaCoffeeShop.DL
{
    class coffeeShopDL
    {
        static public List<string> ordersList = new List<string>();
        static public List<string> orderTaken = new List<string>();

        static public List<menuItem> drinksOnlyList = new List<menuItem>();
        static public List<menuItem> foodOnlyList = new List<menuItem>();

        static public void addMenuItem(menuItem m)
        {
            coffeeShop.menu.Add(m);
        }

        static public void addItem()
        {
            addMenuItem(menuItemUI.getMenuInfo());
        }

        static public void storeMenu(string path, menuItem m)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(m.getName() + "," + m.getType() + "," + m.getPrice());
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string type = (splittedRecord[1]);
                    int price = int.Parse(splittedRecord[2]);
                    menuItem s = new menuItem(name, type, price);
                    addMenuItem(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
