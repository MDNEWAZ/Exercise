using System;

namespace Exercise_3._1
{
   
    
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
        class Program
        {

           

            static void Main(string[] args)
            {
                Console.Write("Enter The width of the image :");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height of the image:");
                var height = Convert.ToInt32(Console.ReadLine());
                var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
                Console.WriteLine("Image orientation is " + orientation);
            }





        }
}

