



using InventoryManagement;
using System.Numerics;
//This is no place for a lazy youth!


// Added some products to the inventory

Product phone1 = new Product("Samsung S8+", 96000, 7, "Phones");
Product lenovo = new Product("Lenovo L530", 94000, 6, "Laptops");
Product phone = new Product("iPhone 6s", 37000, 13, "Phones");
Product phone2 = new Product("iPhone X", 137000, 3, "Phones");
Product shoe = new Product("Flip FLop", 3200, 48, "Shoes");
Product shirt = new Product("Singlets", 3000, 5, "Shirts");
Product rice = new Product("Tiamin Rice", 80000, 20, "Grains");

// **********************************************************************************

ConsoleOutput.WelcomeToApp();

ConsoleOutput.Services();

int choice = "Enter your choice: ".VerifyString();

ManageInventory.Services(choice);

while (choice != 5)
{
    Console.WriteLine("Would you like to do something else?");
    Console.Write("yes/no: ");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "yes")
    {
        Console.Clear();
        ConsoleOutput.Services();
        choice = "Enter your choice: ".VerifyString();
        ManageInventory.Services(choice);
    }
    else
    {
        choice = 5;
    }
}



