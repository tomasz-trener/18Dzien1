using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- cześć 1 -----");

            Console.WriteLine("podaj kolejno dwie liczby");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma = liczba1 + liczba2;

            Console.WriteLine("wynik to: " + suma);
            int liczbaZnakow = Convert.ToString(suma).Length;
            Console.WriteLine("liczba cyfr: " + liczbaZnakow);


            Console.WriteLine("------ częśc 2 -------");
            Console.WriteLine("Podaj dwie liczby oddzielone spacją");
            string rownanie = Console.ReadLine();  // "200 10"
                                                   //     3
            int poz =rownanie.IndexOf(" ");

            int liczba1b = Convert.ToInt32(rownanie.Substring(0, poz));
            int liczba2b = Convert.ToInt32(rownanie.Substring(poz + 1));

            int sumab = liczba1b + liczba2b;
            Console.WriteLine(sumab);


            Console.ReadKey();
        }
    }
}
