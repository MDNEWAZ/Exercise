﻿using System;
using System.Collections.Generic;
namespace Exercise_12
/// <summary>
/// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
/// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
/// and display the result on the console.
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count<=5)
            {
                Console.WriteLine("Please Enter 5 Number Without Repeat (Or Press ENTER to Quit)");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("You've previously entered " + input);
                    continue;
                }
                numbers.Add(input);
            }
            numbers.Sort();
            foreach (var input in numbers)
            {
                Console.WriteLine(input);
            }
        }
    }
}
