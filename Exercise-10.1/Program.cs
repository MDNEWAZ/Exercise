using System;
using System.Collections.Generic;
namespace Exercise_10._1
{
    class Program
    {       
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Input a Name/Or Press Enter to EXIT!");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
                if (names.Count > 2)
                    Console.WriteLine("{0},{1} and {2} other people likes your post", names[0], names[1], names.Count - 2);
                else if (names.Count ==2)
                    Console.WriteLine("{0},{1} like your post",names[0],names[1]);
                else if (names.Count==1)
                    Console.WriteLine("{0} like your post",names[0]);
                else
                    Console.WriteLine();



                
            }
           
        }
    }
}
