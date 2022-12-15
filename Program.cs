using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaketZuordnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int i_paketnummer = 0;
                int i_fach = 0;

                Console.Write("Bitte geben Sie die Paketnummer an: ");
                try
                {
                    i_paketnummer = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw;
                }

                if (i_paketnummer % 4 == 0 || i_paketnummer % 5 == 0)
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
        }
    }
}
