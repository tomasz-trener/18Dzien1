using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak się nazywasz");
            string imie= Console.ReadLine();

            imie = imie.ToUpper();

            Console.WriteLine("Miło mi, " + imie);

            string wiek = Console.ReadLine();

            //wiek = wiek + 1;
            int wiekInt = Convert.ToInt32(wiek);

            long duzaLiczba = 100; // 2^63
            short malaLiczba = 10; // 2^16

            wiekInt = wiekInt + 1;

            Console.WriteLine(wiekInt);

            Console.ReadKey();

        }
    }
}
