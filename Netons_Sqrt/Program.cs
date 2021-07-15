using System;

namespace Newtons_Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Newton's method:");
            Console.WriteLine("Enter the value of c :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
