using System;
using System.Collections.Generic;
/// <summary>
/// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
/// include duplicates. Display the unique numbers that the user has entered.
/// </summary>

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
               
                 Console.WriteLine("Enter a number continiously Or type Quit exit then show all the unique number without dublicate");
                 var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));

            }
            var uniques = new List<int>();
            foreach (var input in numbers)
            {
                if (!uniques.Contains(input))
                    uniques.Add(input);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var input in uniques)
                Console.WriteLine(input);




        }
    }
}
