using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            bool czy = wzrost > 180;
            if (czy) //wzrost > 180
            {
                Console.WriteLine("jesteś wysoki");
            }
            else
            {
                Console.WriteLine("jesteś niski");
            }

            // <160 niski, pomiedzy 160 a 180 sredni a ponad 180 wysoki
            if(wzrost<160)
                Console.WriteLine("niski");     
            else
                if (wzrost > 180)
                {
                    string n = "wysoki";
                    Console.WriteLine(n);
                }
                else
                    Console.WriteLine("sredni");
            // zagnieszdzone ify mozna prawie zawsze
            // przerobic na else ify 

            // nieopytmalne rozwiazanie 
            //if(wzrost<150)
            //    Console.WriteLine("twój wzrost to "+wzrost+"jest bardzo niski");
            //else if(wzrost<160)
            //    Console.WriteLine("twój wzrost to "+wzrost+"jest niski");
            //else if (wzrost <= 180)
            //    Console.WriteLine("twój wzrost to "+wzrost+"jest sredni");
            //else if(wzrost<200)
            //    Console.WriteLine("twój wzrost to "+wzrost+"jest wysoki");
            //else
            //    Console.WriteLine("twój wzrost to "+wzrost+"jest bardzo wysoki");


            string typ;
            if (wzrost < 150)
                typ = "bardzo niski";
            else if (wzrost < 160)
                typ = "niski";
            else if (wzrost <= 180)
                typ = "sredni";
            else if (wzrost < 200)
                typ = "wysoki";
            else
                typ = "bardzo wysoki";
 
            // generowanie dlugich ciąg tekstowych w polaczeniu ze zmiennymi 
            string raport1 = "Twój wzrost wynosi" + wzrost + " i jest " + typ;
            Console.WriteLine(raport1);

            string raport2 = $"Twój wzrost wynosi {wzrost} i jest {typ}";
            string raport3 = string.Format("Twój wzrost wynosi {0} i jest {1}",
                wzrost, typ);

            // operatory skrótowe 

            string wyn1;
            if (wzrost > 180)
                wyn1 = "wysoki";
            else
                wyn1 = "niski";

            string wyn2 = wzrost > 180 ? "wysoki" : "niski";

            string wyn3 = wzrost > 200 ? "bardzo wysoki" : wzrost < 160 ? "niski" : "sredni";

        }
    }
}
