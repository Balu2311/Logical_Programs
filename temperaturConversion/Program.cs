using System;

namespace temperaturConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Temperatur Conversion");
            double celsius_C;
            double farhenhit_F;

           
                Console.WriteLine("enter the option ");

                int  temperature = Convert.ToInt32(Console.ReadLine());
                switch (temperature)
                {
                    case 1:
                        Console.WriteLine("enter the temperature ");

                        farhenhit_F = Convert.ToInt32(Console.ReadLine());
                        celsius_C = (farhenhit_F * 9 / 5) + 32;
                        Console.WriteLine("the clesius :  " + celsius_C);
                        break;
                    case 2:
                        Console.WriteLine("enter the temperature");

                        celsius_C = Convert.ToInt32(Console.ReadLine());
                        farhenhit_F = (celsius_C - 32) * 5 / 9;
                        Console.WriteLine("the farhenhit : " + farhenhit_F);
                        break;
                }
        }
    }
}
