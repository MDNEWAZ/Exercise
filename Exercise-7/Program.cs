using System;

namespace Exercise_7
{
    class Program
    {
        public static void Main()
        {

            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);

        }



    }
}
