using System;
using System.Collections.Generic;

namespace Ismetles1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dontes = true;

            while (dontes)
            {

            string[] lehetoseg = new string[] {"Kő", "Papír", "Olló"} ;

            Random vel = new Random();

            int gepValasz = vel.Next(0, 3);

            Console.WriteLine($"Gép választása: {lehetoseg[gepValasz]}");

            int jatekosValasz;

            Console.WriteLine("Kő 0 ; Papír 1 ; Olló 2");

            Console.Write("Válassz: "); jatekosValasz = int.Parse(Console.ReadLine());

                if (jatekosValasz < 3)
                {
                    Console.WriteLine($"Játékos választása: {lehetoseg[jatekosValasz]}");
                    switch (jatekosValasz)
                    {
                        default:
                            break;
                        case 0:
                            if (gepValasz == 0)
                            {
                                Console.WriteLine("A gép is követ válaszott, döntetlen.");
                            }
                            else if (gepValasz == 1)
                            {
                                Console.WriteLine("A gép papírt válaszott, vesztettél.");
                            }
                            else if (gepValasz == 2)
                            {
                                Console.WriteLine("A gép ollót választott, nyertél.");
                            }
                            break;
                        case 1:
                            if (gepValasz == 0)
                            {
                                Console.WriteLine("A gép követ válaszott, nyertél.");
                            }
                            else if (gepValasz == 1)
                            {
                                Console.WriteLine("A gép is papírt válaszott, döntetlen.");
                            }
                            else if (gepValasz == 2)
                            {
                                Console.WriteLine("A gép ollót választott, vesztettél.");
                            }
                            break;
                        case 2:
                            if (gepValasz == 0)
                            {
                                Console.WriteLine("A gép követ válaszott, vesztettél.");
                            }
                            else if (gepValasz == 1)
                            {
                                Console.WriteLine("A gép papírt válaszott, nyertél.");
                            }
                            else if (gepValasz == 2)
                            {
                                Console.WriteLine("A gép is ollót választott, döntetlen.");
                            }
                            break;
                    }
                    Console.Write($"Szeretnél még játszani? I/N {" "}");
                    char valasz;
                    valasz = char.Parse(Console.ReadLine());
                    if (valasz == 'N')
                    {
                        dontes = false;
                    }
                }
                else
                {
                    Console.WriteLine("Rossz számot írtál, a program bezár.");
                    dontes = false;
                }
            }
        }
    }
}












































































































































































































































































































































































































































































































