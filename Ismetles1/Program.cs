using System;
using System.Collections.Generic;

namespace Ismetles1
{
    class Program
    {
        static int jatekospont = 0, geppont = 0;
        static void Main(string[] args)
        {
            bool dontes = true; //A végén kerül eldöntésre, hogy folytatódik-e a játék
            
            while (dontes)
            {

            string[] lehetoseg = new string[] {"Kő", "Papír", "Olló"} ;

            Random vel = new Random();

            int gepValasz = vel.Next(0, 3);

            Console.WriteLine($"Jelenlegi állás: Játékos:{jatekospont} Gép:{geppont}");

            int jatekosValasz;

            Console.WriteLine("Kő 0 ; Papír 1 ; Olló 2");

            Console.Write("Válassz: "); jatekosValasz = int.Parse(Console.ReadLine());

                if (jatekosValasz < 3) //Túl nagy szám kiküszöbölése
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
                                geppont++;
                            }
                            else if (gepValasz == 2)
                            {
                                Console.WriteLine("A gép ollót választott, nyertél.");
                                jatekospont++;
                            }
                            break;
                        case 1:
                            if (gepValasz == 0)
                            {
                                Console.WriteLine("A gép követ válaszott, nyertél.");
                                jatekospont++;
                            }
                            else if (gepValasz == 1)
                            {
                                Console.WriteLine("A gép is papírt válaszott, döntetlen.");
                            }
                            else if (gepValasz == 2)
                            {
                                Console.WriteLine("A gép ollót választott, vesztettél.");
                                geppont++;
                            }
                            break;
                        case 2:
                            if (gepValasz == 0)
                            {
                                Console.WriteLine("A gép követ válaszott, vesztettél.");
                                geppont++;
                            }
                            else if (gepValasz == 1)
                            {
                                Console.WriteLine("A gép papírt válaszott, nyertél.");
                                jatekospont++;
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
                    if (valasz == 'N' || valasz == 'n')
                    {
                        dontes = false;
                    }
                }
                else
                {
                    Console.WriteLine("Rossz számot írtál, a program bezár.");
                    dontes = false;
                }
                Console.Clear();
            }
        }
    }
}












































































































































































































































































































































































































































































































