using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menuprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            bool rightKey = true;
            
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+          Maak uw keuze:                    +");
            Console.WriteLine("+                                            +");
            Console.WriteLine("+           1 Voetbal                        +");
            Console.WriteLine("+                                            +");
            Console.WriteLine("+           2 Tennis                         +");
            Console.WriteLine("+                                            +");
            Console.WriteLine("+           3 Sumo Worstelen                 +");
            Console.WriteLine("+                                            +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");

            do
            {
                
                cki = Console.ReadKey(true);

                if (cki.Key == ConsoleKey.D1 ||
                     cki.Key == ConsoleKey.D2 ||
                     cki.Key == ConsoleKey.D3)
                {
                    rightKey = false;
                }
            } while (rightKey);
            Console.WriteLine("Er is op 1, 2 of 3 gedrukt");

            Console.ReadLine();
        }
    }
}
