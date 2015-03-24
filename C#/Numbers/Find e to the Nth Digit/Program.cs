// Find e to the Nth Digit:
// "Enter a number and have the program generate e up to that many decimal places.
// Keep a limit to how far the program will go."
// @author: Piotr C. Marzec, PL

using System;

namespace Find_e_to_the_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (14 is maximum value):");
            int range = Convert.ToSByte(Console.ReadLine());

            if (range > 0 && range < 15)
            {
                decimal value = new decimal(Math.E);
                decimal rounded_value = decimal.Round(value, range);
                Console.WriteLine("Rounded e value = {0}", rounded_value);
            }

            else
            {
                Console.WriteLine("You've entered a wrong value");
            }

            Console.ReadKey();
        }
    }
}
