using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            Console.WriteLine("Enter the Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.WriteLine("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.WriteLine("\nSo, The Number is Perfect.");
            else
                Console.WriteLine("\nSo, The Number is not Perfect.");
            Console.WriteLine("\n");
        }
    }
}

