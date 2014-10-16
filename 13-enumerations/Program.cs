using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_enumerations
{
    /*
    public enum MonthsOfYear { januari = 1, februari = 0, march = 3, april = 4, may = 6, june = 5,
                                juli = 7, august = 10, september = 9, oktober = 12,
                                    november = 11, december = 2 }
    */
    public enum MonthsOfYear  { januari, februari, march, april, may, june, juli,
                                    august, september, oktober, november, december }
    
    class Program
    {
        static void Main(string[] args)
        {
            MonthsOfYear month, huidigeMaand;
            month = MonthsOfYear.oktober;            
            
            /* Om de vergelijking te maken met een gewone variabele
            int geheelgetal;
            geheelgetal = 5;
            geheelgetal++;
            Console.WriteLine("Ik heb een getal verhoog met 1. het heeft nu de waarde: {0}", geheelgetal);
            */           

            huidigeMaand = MonthsOfYear.februari;
            Console.WriteLine("De huidige maand is: {0}", huidigeMaand);

            ConsoleKeyInfo cki;

            do
            {
                Console.Write("Verhoog of verlaag de maand met 1, Druk op pijl omhoog of omlaag");
                
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    // Maak hier een begrenzing
                    huidigeMaand++;
                }
                else if (cki.Key == ConsoleKey.DownArrow)
                {
                    // Maak hier een begrenzing
                    huidigeMaand--;
                }

                Console.Clear();
                switch (huidigeMaand)
                {
                    case MonthsOfYear.januari:
                        Console.WriteLine("De huidige maand van het jaar is nu: Januari");
                        break;
                    case MonthsOfYear.februari:
                        Console.WriteLine("De huidige maand van het jaar is: Februari");
                        break;
                    case MonthsOfYear.march:
                        Console.WriteLine("De huidige maand van het jaar is: Maart");
                        break;
                    case MonthsOfYear.may:
                        Console.WriteLine("De huidige maand van het jaar is: Mei");
                        break;
                    case MonthsOfYear.april:
                        Console.WriteLine("De huidige maand van het jaar is: April");
                        break;
                    case MonthsOfYear.june:
                        Console.WriteLine("De huidige maand van het jaar is: Juni");
                        break;
                    case MonthsOfYear.juli:
                        Console.WriteLine("De huidige maand van het jaar is: Juli");
                        break;
                    case MonthsOfYear.august:
                        Console.WriteLine("De huidige maand van het jaar is: Augustus");
                        break;
                    case MonthsOfYear.september:
                        Console.WriteLine("De huidige maand van het jaar is: September");
                        break;
                    case MonthsOfYear.oktober:
                        Console.WriteLine("De huidige maand van het jaar is: Oktober");
                        break;
                    case MonthsOfYear.november:
                        Console.WriteLine("De huidige maand van het jaar is: November");
                        break;
                    case MonthsOfYear.december:
                        Console.WriteLine("De huidige maand van het jaar is: December");
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
            


            //Console.ReadLine();
        }
    }
}
