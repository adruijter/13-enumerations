using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace menu
{
    class Program
    {
        public enum Menu { appel, sinaasappel, banaan, geenKeuze }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Menu menuKeuze = Menu.geenKeuze;
            bool goedeKeuze = false;

            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+ Maak uit het onderstaande menu een keuze: +");
                Console.WriteLine("+                                           +");
                Console.WriteLine("+        1 appel                            +");
                Console.WriteLine("+        2 sinaasappel                      +");
                Console.WriteLine("+        3 banaan                           +");
                Console.WriteLine("+                                           +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.D3)
                {
                    Console.WriteLine(cki.Key.ToString());
                    goedeKeuze = true;
                    //menuKeuze = Convert.ToInt32(
                    
                    //menuKeuze = (Menu)Convert.ToInt32();
                }

                switch (menuKeuze)
                {
                    case Menu.appel:
                        Console.WriteLine("appel {0}", menuKeuze.ToString());
                        
                        break;
                    case Menu.sinaasappel:
                        Console.WriteLine("sinaasappel");
                        break;
                    case Menu.banaan:
                        Console.WriteLine("banaan");
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (goedeKeuze);
            Console.Clear();
            Console.ReadLine();
        }
    }
}
