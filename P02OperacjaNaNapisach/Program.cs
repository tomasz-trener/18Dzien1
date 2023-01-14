using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjaNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
                          //012345678910  
            int dlugosc = napis.Length; // 11

            // Console.WriteLine(dlugosc);
            Console.WriteLine(dlugosc);

            string s1 = napis.Substring(4); //ma kota
            string s2 = napis.Substring(4, 2); //ma
            //napis.Substring(4, 2);

            Console.WriteLine(s1);

            bool czyZawiera= napis.Contains("ma"); // true lub false 

            bool typLogiczny = false;

            string s3 = napis.ToUpper(); // zamiana na duze litery
            string s4 = napis.ToLower();

            // konkatencja napisów
            string s5 = "ala" + "ma" + "kota";
            // "alamakota"
            string s6 = napis + " i psa";
            // ala ma kota i psa

            string s7 =  "ala".ToUpper(); //ALA

            string s8 = "ala";
            //s8 = s8.ToUpper(); 
            s8.ToUpper(); // ten wynik nie jest do niczego przypisany
            Console.WriteLine(s8);


            string s9= napis.Replace("ma", "bedzie miała");
            // ala bedzie miala kota

            int pozycja= napis.IndexOf("ma"); //4


            Console.ReadKey();

        }
    }
}
