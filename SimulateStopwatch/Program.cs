﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SimulateStopwatch
{
    class Stopwatch
    {
        static long hour1, hour2;
        static long minutes1, minutes2;
        static long seconds1, second2;
        static long milliseconds1, milliseconds2;
        public Stopwatch()
        {

            DateTime dt = new DateTime();
            Console.WriteLine("enter s for start and x for end");
            string option = Console.ReadLine();
            if (option == "s" || option == "S")
            {
                hour1 = dt.Hour;
                minutes1 = dt.Minute;
                seconds1 = dt.Second;
                milliseconds1 = dt.Millisecond;
            }
            if (option == "x" || option == "X")
            {
                hour2 = dt.Hour;
                minutes2 = dt.Minute;
                second2 = dt.Second;
                milliseconds2 = dt.Millisecond;


            }
            Console.WriteLine("the time elapsion: ");

            Console.WriteLine(hour2 - hour1);



        }
    }
}


