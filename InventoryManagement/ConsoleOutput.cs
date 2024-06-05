using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public static class ConsoleOutput
    {
        public static void WelcomeToApp()
        {
            Console.WriteLine("WELCOME TO THE INVENTORY MANAGEMENT SYSTEM");
            Console.WriteLine("__________________________________________");
            Console.WriteLine();
        }
        public static void Services()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. Update product information");
            Console.WriteLine("3. Remove a product");
            Console.WriteLine("4. View current inventory");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }
        public static void PartsOfAProduct(Product productToUpdate)
        {
            Console.Clear();
            Console.WriteLine("What will you like to edit?");
            Console.WriteLine($"1. Name:     {productToUpdate.Name}");
            Console.WriteLine($"2. Price:    {productToUpdate.Price}");
            Console.WriteLine($"3. Quantity: {productToUpdate.Quantity}");
            Console.WriteLine($"4. Category: {productToUpdate.Category}");
            Console.WriteLine();
        }
        public static void PrintEntireStock()
        {
            Console.Clear();
            string allProducts = Product.AllProducts();
            Console.WriteLine(allProducts);
            Console.WriteLine();
        }
        public static void GoodBye()
        {
            Console.Clear();
            Console.WriteLine("Thank you for your patronage.");
            Console.WriteLine();
        }
    }
}
