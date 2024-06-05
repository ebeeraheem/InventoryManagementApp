using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal static class ManageInventory
    {
        public static void Services(int choice)
        {
            switch (choice)
            {
                case 1:
                    ManageProduct.AddProduct();
                    break;
                case 2:
                    ManageProduct.UpdateProduct();
                    break;
                case 3:
                    ManageProduct.RemoveProduct();
                    break;
                case 4:
                    ConsoleOutput.PrintEntireStock();
                    break;
                case 5:
                    ConsoleOutput.GoodBye();
                    break;
                default:
                    break;
            }
        }
    }
}
