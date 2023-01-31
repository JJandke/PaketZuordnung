using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaketZuordnung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i_abbruch = 1;

            int user_input(int i_paketnummer)
            {
                Console.Write("Bitte geben Sie die Paketnummer an: ");
                try
                {
                    i_paketnummer = Convert.ToInt16(Console.ReadLine());
                    return i_paketnummer;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            while (i_abbruch != 0)
            {
                int i_paketnummer = 0;
                int i_fach = 0;

                user_input(i_paketnummer);


                if (i_abbruch == 0)
                {
                    break;
                }

                else if (i_paketnummer < 1000 || i_paketnummer > 9999)
                {
                    Console.WriteLine("Sie haben " + i_paketnummer + "eingegeben. Dies ist keine gültige Paketnummer.");
                    user_input(i_paketnummer);

                }

                else if (i_paketnummer % 4 == 0 || i_paketnummer % 5 == 0)
                {
                    if (i_paketnummer % 100 == 0)
                    {
                        if (i_paketnummer % 400 == 0)
                        {
                            i_fach = 3;
                        }
                        else
                        {
                            i_fach = 2;
                        }
                    }
                    else
                    {
                        i_fach = 1;
                    }
                }
                else
                {
                    i_fach = 4;
                }
                Console.WriteLine("Das Paket ist in Fach Nr. " + i_fach + "\nZum Fortfahren beliebige Taste drücken!\n");
                Console.ReadKey();
            }
            Console.WriteLine("Beenden des Programms:\nDrücken Sie eine beliebige Taste um das Programm zu beenden");
            Console.ReadKey();
        }
    }
}
