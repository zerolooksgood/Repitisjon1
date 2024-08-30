using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitisjon1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            //Bruker List fordi den kan utvides uendelig
            List<string> mineOrd = new List<string>();

            //Oppg 4
            string input = "";
            while (input.ToLower() != "s")
            {
                Console.WriteLine("Skriv \"i\" for å slå sammen to ord\nSkriv \"u\" for å skrive ut alle ordene så langt\nSkriv \"s\" for å avslutte");
                input = Console.ReadLine();
                if (input.ToLower() == "i")
                {
                    Console.WriteLine("Hva er det første ordet?");
                    string i1 = Console.ReadLine();
                    Console.WriteLine("Hva er dte andre ordet?");
                    string i2 = Console.ReadLine();
                    mineOrd.Add(slaaSammen(i1,i2));
                } else if (input.ToLower() == "u")
                {
                    skrivUt(mineOrd);
                }
            }
        }

        //Oppg 2
        static string slaaSammen(string a, string b)
        {
            string product = a + b;
            return product;
        }

        //Oppg 3
        static void skrivUt(List<string> list)
        {
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
