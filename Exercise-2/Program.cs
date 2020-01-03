

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
            int a;
            int b;
            int min;
            int max;

            //input numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            //finding max number using if-else
            if (a > b)
                max = a;
            else
                max = b;


            Console.WriteLine("Maximum number = {0}", max);

            //finding max number using ternary operator
            //max = (a > b) ? a : b;



          
            

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
