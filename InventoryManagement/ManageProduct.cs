using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal static class ManageProduct
    {
        public static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("ADD A NEW PRODUCT");
            Console.WriteLine();
            //Name
            string name = "What is the name of the product: ".VerifyName();
            //Price
            decimal price = "What is the price of one unit of the product: ".VerifyDecimal();
            //Quantity
            int quantity = $"How many units of {name} would you like to add: ".VerifyInt();
            //Category
            string category = $"What category does {name} belongs to: ".VerifyName();

            Product newProduct = new Product(name, price, quantity, category);
            Console.WriteLine();

            Console.WriteLine($"{quantity} units of {name} were successfully added to the inventory.");
            Console.WriteLine();
        }

        public static Product SelectAProduct()
        {
            Console.WriteLine("Which product will you like to modify?");
            string modify = "Enter product name: ".VerifyName();
            Product productToUpdate = Product.GetProduct(modify);

            while (productToUpdate == null)
            {
                Console.WriteLine("Please enter a valid product name.");
                modify = "Enter product name: ".VerifyName();
                productToUpdate = Product.GetProduct(modify);
            }

            return productToUpdate;
        }

        public static void UpdateProduct()
        {
            Console.Clear();
            Console.WriteLine("UPDATE PRODUCT INFORMATION");
            Console.WriteLine();

            Product productToUpdate = SelectAProduct();
            ConsoleOutput.PartsOfAProduct(productToUpdate);

            int toEdit = "Enter your choice: ".VerifyString();
            while (toEdit < 0 || toEdit > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 - 4.");
                toEdit = "Enter your choice: ".VerifyString();
            }

            if (toEdit == 1)
            {
                //Edit name
                string newName = "Enter new name: ".VerifyName();
                Product.SetNewName(productToUpdate.Name, newName);
                Console.WriteLine($"Name successfully updated to {productToUpdate.Name}");
            }
            else if (toEdit == 2)
            {
                //Edit price
                decimal newPrice = "Enter new price: ".VerifyDecimal();
                Product.SetNewPrice(productToUpdate.Name, newPrice);
                Console.WriteLine($"Price successfully updated to {productToUpdate.Price}");
            }
            else if (toEdit == 3)
            {
                //Edit quantity
                int newQuantity = "Enter new quantity: ".VerifyInt();
                Product.SetNewQuantity(productToUpdate.Name, newQuantity);
                Console.WriteLine($"Quantity successfully updated to {productToUpdate.Quantity}");
            }
            else if (toEdit == 4)
            {
                //Edit category
                string newCategory = "Enter new category: ".VerifyName();
                Product.SetNewCategory(productToUpdate.Name, newCategory);
                Console.WriteLine($"Category was successfully updated to {productToUpdate.Category}");
            }
            Console.WriteLine();
        }

        public static void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("REMOVE A PRODUCT");
            Console.WriteLine();

            int remove = "Which product will you like to remove: ".VerifyInt();
            Product.RemoveProduct(remove);
            Console.WriteLine();
            Console.WriteLine("Product successfully removed.");
            Console.WriteLine();
        }
    }
}
