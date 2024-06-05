using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal static class VerifyInput
    {
        //Get a string input and return a non-negative numeric output
        public static int VerifyInt(this string message)
        {
            int output;
            bool validNumber = false;

            Console.Write(message);
            string choice = Console.ReadLine();

            validNumber = int.TryParse(choice, out output);


            while (validNumber == false || output <= 0)
            {
                Console.WriteLine("That was an invalid choice. Please enter a number greater than 0.");
                Console.Write(message);
                choice = Console.ReadLine();
                validNumber = int.TryParse(choice, out output);
            }

            return output;
        }

        //Get a string and return a number 1 - 5
        public static int VerifyString(this string message)
        {
            int output = VerifyInt(message);

            while (output > 5)
            {
                Console.WriteLine("That was an invalid choice. Please enter a number.");
                output = VerifyInt(message);
            }

            return output;
        }

        //Get a string and return it if it isn't null or white space
        public static string VerifyName(this string message)
        {
            string output = string.Empty;

            Console.Write(message);
            output = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(output) /*|| output.All(char.IsLetter) == false*/)
            {
                Console.WriteLine("Name cannot be empty!");
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        //Get a string and return a decimal
        public static decimal VerifyDecimal(this string message)
        {
            decimal output;
            string textNum;
            bool validDecimal = false;

            Console.Write(message);
            textNum = Console.ReadLine();

            validDecimal = decimal.TryParse(textNum, out output);

            while (validDecimal == false || output <= 0)
            {
                Console.WriteLine("That was an invalid price. Price cannot be empty or negative.");
                Console.Write(message);
                textNum = Console.ReadLine();

                validDecimal = decimal.TryParse(textNum, out output);

            }

            return output;
        }

        
    }
}
