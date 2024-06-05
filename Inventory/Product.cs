
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {
        //A private static backing field to store product ID
        private static int s_id = 0;
        public string Name { get; private set; }
        public int ID { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string Category { get; private set; }
        public DateTime DateAdded { get; private set; }

        public Product(string name, decimal price, int quantity, string category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;

            //Increase the product ID and set it as the new product's ID
            s_id++;
            ID = s_id;

            //Record the time each product was added
            DateAdded = DateTime.Now;

            _allProducts.Add(this);
        }
        //This will act as a warehouse that stores all products
        private static List<Product> _allProducts = new List<Product>();        

        //Return a record of all products
        public static string AllProducts()
        {
            string output = "ID  PRODUCT NAME\tCATEGORY\t\tQUANTITY\tPRICE\t\tDATE ADDED";

            foreach (Product product in _allProducts)
            {
                output += $"\n{product.ID}   {product.Name}\t\t{product.Category}\t\t\t{product.Quantity}\t\t{product.Price:C}\t{product.DateAdded:g}";
            }

            int totalInStock = 0;
            decimal totalPrice = 0;

            foreach (Product product in _allProducts)
            {
                totalInStock += product.Quantity;
                totalPrice += product.Price;
            }

            output += $"\n\nTOTAL\nPRODUCTS: {totalInStock}\nAMOUNT: {totalPrice:C}";

            return output;
        }


        //Remove a product
        public static void RemoveProduct(int remove)
        {
            foreach (Product product in _allProducts)
            {
                //I added -1 because of zero-based indexing in lists
                if (product.ID == remove)
                {
                    _allProducts.RemoveAt(remove - 1);
                    break;
                }
            }            
        }

        //Get a product
        public static Product GetProduct(string update)
        {
            Product output = null;

            foreach (Product product in _allProducts)
            {
                if (product.Name.ToLower() == update.ToLower())
                {
                    output = product;
                }
            }

            return output;
        }
        
        //Change the name of a product
        public static void SetNewName(string name, string newName)
        {
            Product changeName = GetProduct(name);
            changeName.Name = newName;
        }
        public static void SetNewPrice(string name, decimal newPrice)
        {
            Product changePrice = GetProduct(name);
            changePrice.Price = newPrice;
        }
        public static void SetNewQuantity(string name, int newQuantity)
        {
            Product changeQuantity = GetProduct(name);
            changeQuantity.Quantity = newQuantity;
        }
        public static void SetNewCategory(string name, string newCategory)
        {
            Product changeCategory = GetProduct(name);
            changeCategory.Category = newCategory;
        }
    }
}
