using System;

namespace Mathematical_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            double angleDegres, inRadians, inDegrees, positive;
            Console.Write("Enter an angle in degrees: ");
            angleDegres = Convert.ToDouble(Console.ReadLine());

              inRadians = (angleDegres * (Math.PI) / 180);
            inDegrees = Math.Sin(inRadians);
            Console.WriteLine("Sine of the angle is: " + Math.Round(inDegrees, 2));

            Console.ReadLine();
            Console.Write("Enter a positive number: ");
            positive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square root of the number is: " + Math.Sqrt(positive));
            Console.ReadLine();
        }
    }
}
