using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Prime Numbers");
            int num, i, ctr, STNO, ENDNO;
            Console.Write("Input starting number of range: ");
            STNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            ENDNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", STNO, ENDNO);

            for (num = STNO; num <= ENDNO; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("\n{0} ", num);
            }
        }
    }
}
