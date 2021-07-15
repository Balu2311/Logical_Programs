using System;

namespace monthlyPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Monthly Payment ");
            Console.WriteLine("Enter the duration of the loan (in years): ");
            double years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the princple ammount: ");
            double principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the interest rate: ");
            double rate = Convert.ToInt32(Console.ReadLine());
            rate = rate / 100;
            Console.WriteLine("\nBased on these values entered:");
            Console.WriteLine(" - Number of years .... {0}", years);
            Console.WriteLine(" - Principal amount ... {0:c}", principal);
            Console.WriteLine(" - Interest rate ...... {0:p}", rate);

            double monthlyRate = rate / 12;
            double payments = 12 * years;

            double result =
                principal *
                (monthlyRate * Math.Pow(1 + monthlyRate, payments)) /
                (Math.Pow(1 + monthlyRate, payments) - 1);

            Console.WriteLine("\nYour monthly payment will be: {0}", Math.Round(result));
            Console.ReadLine();

        }
    }
}
