﻿using System;
/// <summary>
/// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
/// If the user guesses the number, display “You won". Otherwise, display “You lost".
/// </summary>

namespace Exercisre_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);

            
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                    
                }
            }

            Console.WriteLine("You lost!");
            Console.WriteLine("Secret is " + number);
        }
    }
}
