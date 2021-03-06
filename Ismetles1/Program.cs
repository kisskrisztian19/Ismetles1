﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Ismetles1
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };
        static bool dontes = true; //A végén kerül eldöntésre, hogy folytatódik-e a játék
        static Random vel = new Random();
        static int gepValasz;
        static int jatekospont, geppont, menetszam, jatekosValasz;

        static void StatisztikaFajlbol()
        {
            StreamReader stat = new StreamReader("Statisztika.txt");
            Console.WriteLine("Eddigi játékaid eredményei:");
            while (!stat.EndOfStream)
            {
                string[] sor = new string[3];
                sor = stat.ReadLine().Split(';');
                menetszam = int.Parse(sor[0]);
                jatekospont = int.Parse(sor[1]);
                geppont = int.Parse(sor[2]);
                Console.WriteLine($"Menetek:{menetszam} Játékos:{jatekospont} Gép:{geppont}");
            }
            Console.WriteLine("Statisztika vége.");
            menetszam = 0; jatekospont = 0; geppont = 0;
            stat.Close();
        }
        static void Valasztas()
        {
            Console.WriteLine("Kő 0 ; Papír 1 ; Olló 2");
            try
            {
                Console.Write("Válassz: "); jatekosValasz = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                try
                {
                    Console.WriteLine("Rossz értéket adtál meg, válassz újra: 0,1,2");
                    jatekosValasz = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    dontes = false;
                }

            }
        }
        static void Jatek()
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
            
        }
        static void Folytassa_e()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.Write($"Szeretnél még játszani? I/N {" "}");
            char valasz;
            valasz = char.Parse(Console.ReadLine().ToLower());
            if (valasz == 'n')
            {
                dontes = false;
            }
        }
        static void StatFajlba()
        {
            StreamWriter iras = new StreamWriter("Statisztika.txt", true);
            iras.WriteLine($"{menetszam};{jatekospont};{geppont}");
            iras.Close();
        }
        static void Main(string[] args)
        {
            StatisztikaFajlbol();
            while (dontes)
            {
                gepValasz = vel.Next(0, 3);
                Valasztas(); //A játékos lehetőséget választ, ahogy a gép választása is megtörténik
                if (dontes == false)
                {
                    Console.WriteLine("Kétszer is rossz értéket adtál meg, a program bezár.");
                    //Ha a választásnál kétszer is hibázik a játékos, a program nem hajtja végre a játék többi részét.
                }
                else
                {
                    Jatek(); //A játék menete, switch-case alapján eredmény eldöntése
                    Folytassa_e(); /* A while ciklus újraindítására teszi fel a kérdést, ha a játékos nem akarja folytatni a játékot,
                                     a "dontes" bool false-ra vált, és a ciklus a végén megáll.}                                      */
                    menetszam++;
                    
                    Console.Clear();
                }
            }
            StatFajlba();
        }
    }
}











































































































































































































































































































































































































































































































