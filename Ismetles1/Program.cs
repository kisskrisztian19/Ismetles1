﻿using System;
using System.Collections.Generic;

namespace Ismetles1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lehetoseg = new string[] {"Kő", "Papír", "Olló"} ;

            Random vel = new Random();

            int gepValasz = vel.Next(0, 3);

            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValasz]);

            Console.ReadKey();
        }
    }
}












































































































































































































































































































































































































































































































