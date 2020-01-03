using System;

namespace Exercise_1
{
    
    class Program
    {      
        static void Main(string[]args)
        {
            Console.WriteLine("Enter a number between 1 to 10");
           var m = Console.ReadLine();
           var k = Convert.ToInt32(m);
            if(k<=10 && k>=0)
            {
                Console.WriteLine("Congrats!!! you enter a valid number");
            }

            else
            {
                Console.WriteLine("You Enter  a Invalid number");

            }

        }
    }
}
