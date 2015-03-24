// Fibonacci Sequence:
// "Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number."
// @author: Piotr C. Marzec, PL

using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int range = Convert.ToSByte(Console.ReadLine());
            int[] array = new int[range];
            array[1] = 1;

            if (range == 0)
            {
                Console.WriteLine("Fibonacci Sequence: 0");
            }
            else if (range == 1)
            {
                Console.WriteLine("Fibonacci Sequence: 1");
            }
            else 
            {
                Console.Write("Fibonacci Sequence: 0 + 1 + ");
                for (int i = 2; i < range; i++)
                {
                        array[i] = (array[i - 1] + array[i - 2]);
                        if (i == range-1)
                        {
                            Console.Write("{0}", array[i]);
                        }
                        else
                        {
                            Console.Write("{0} + ", array[i]);
                        }
                }
            }
        
            Console.ReadKey();
        }
    }
}
