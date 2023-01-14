using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieInstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj rownanie matematyczne") ;
            string rownanie = Console.ReadLine(); // 6*2

            // wersja 1 
            //string op = rownanie.Substring(1, 1);
            //double liczba1 = Convert.ToDouble(rownanie.Substring(0, 1));
            //double liczba2 = Convert.ToDouble(rownanie.Substring(2));

            // wersja 2 
            int pozPlus = rownanie.IndexOf("+"); //-1
            int pozMin = rownanie.IndexOf("-");  //-1
            int pozMnoz = rownanie.IndexOf("*"); // konretna pozycja
            int pozDziel = rownanie.IndexOf("/"); // -1

            string op;
            double liczba1;
            double liczba2;
            if (pozPlus > -1)
            {
                op = "+";
                liczba1 = Convert.ToDouble(rownanie.Substring(0, pozPlus));
                liczba2 = Convert.ToDouble(rownanie.Substring(pozPlus+1));
            }
            else if (pozMin > -1)
            {
                op = "-";
                liczba1 = Convert.ToDouble(rownanie.Substring(0, pozMin));
                liczba2 = Convert.ToDouble(rownanie.Substring(pozMin + 1));
            }
            else if (pozMnoz > -1)
            {
                op = "*";
                liczba1 = Convert.ToDouble(rownanie.Substring(0, pozMnoz));
                liczba2 = Convert.ToDouble(rownanie.Substring(pozMnoz + 1));
            }
            else
            {
                op = "/";
                liczba1 = Convert.ToDouble(rownanie.Substring(0, pozDziel));
                liczba2 = Convert.ToDouble(rownanie.Substring(pozDziel + 1));
            }



            double? wynik = null;
            if (op == "+")
                wynik = liczba1 + liczba2;
            else if (op == "-")
                wynik = liczba1 - liczba2;
            else if (op == "*")
                wynik = liczba1 * liczba2;
            else if (op == "/")
                wynik = liczba1 / liczba2;
            //else
            //    wynik = "zle";
           
            //double? wynik = null;
            //wynik = op == "+" ? liczba1 + liczba2 : op == "-" ? liczba1 - liczba2 : op == "*" ? liczba1 * liczba2 : op == "/" ? liczba1 / liczba2;                



            if (wynik != null)
                Console.WriteLine("wynik to " + wynik);
            else
                Console.WriteLine("podano nieznany operator");


            Console.ReadKey();
        }
    }
}
