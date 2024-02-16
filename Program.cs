using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + pieces + " apple(s): ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of original price is " + totalPrice);
            int convertedPrice = (int)totalPrice;
            Console.WriteLine("The value of converted price is " + convertedPrice);
            Console.Write("\nPress any key to exit.....");
            Console.ReadKey();
        }
    }
}
