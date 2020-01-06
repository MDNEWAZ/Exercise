

using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            
            {
                Console.Write("Enter a number: ");
                var number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                var number2 = Convert.ToInt32(Console.ReadLine());

                var max = (number1 > number2) ? number1 : number2;
                Console.WriteLine("Max is " + max);
            }
        }
    }
}
