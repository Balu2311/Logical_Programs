using System;

namespace ReverceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Reverse Number");
            int num, r, sum = 0, t;

            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            //For loop
            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);

            //    //While Loop
            //    //while (num != 0)
            //    //{
            //    //    r = num % 10;
            //    //    sum = sum * 10 + r;
            //    //    num /= 10;
            //    //}
            //    //Console.Write("Reversed Number: " + sum);

            }
            ////Recursion Method
            //public static void fun(int n)
            //{
            //    if(n < 10)
            //    {
            //        Console.WriteLine(n);
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine(n % 10);
            //        fun(n / 10); // this method calling recursion
            //    }
            //}
            //static void Main(String[] args)
            //{
            //    int num = 0;
            //    Console.WriteLine("Enter the Number : ");
            //    num = int.Parse(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        Console.WriteLine("Reverse Number : ");
            //    fun(num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter Postive Number");
            //        //Console.ReadLine();
            //    }
            //}
        }
    }
