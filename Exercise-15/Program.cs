using System;
using System.Collections.Generic;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                
                Console.WriteLine("Enter a few numbers separated by a hyphen");
                 var numbers =  Console.ReadLine();
                
                Console.WriteLine(numbers.Split("-"));
                Console.ReadKey();




            }
           

        }
    }
}
