using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the month: 1 to 12 ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year:four digits");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the day : 1 to 31");
            int day = Convert.ToInt32(Console.ReadLine());
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;

            int d0 = (day + x + 31 * m0 / 12) % 7;
            Console.WriteLine("Date: {0}-{1}-{2}", day, month, year);
            switch (d0)
            {

                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wdnesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("satureday");
                    break;
                default:
                    Console.WriteLine("no day found");
                    break;
            }
        }
    }
}

