using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            bool czy = a == 1;

            a = a + 1;
            a++; // zwieksz o 1

            a += 5; // wieksz o 5 zamiast a = a+5

            a *= 2; // a = a*2 lub dowolna inna wartosc
                    // 
            a -= 4; // a = a-4

            a /= 2; // przedziel przez 2 

            bool czyMniejsze = a < 2;
            bool czyWiekszeLubRowne = a >= 5;

            bool b1 = (a < 5 || a > 10) && a % 2 ==0; // lub
            bool b2 = a > 5 && a < 20; // i

            bool b3 = a != 5; // rózne od 5 

            bool b4 = !(a == 5);// nieprawda, że a jest równe 5 to samo co a!=5

            int c = 10 / 3; // wynik 3 
            double d = 5.7; // double pozwala na przechwywanie wartosci niecalkowitych

            double e = 10 / 3; // wynik: 3

            double f = 10.0 / 3; // 3.3333
            double g = 10 / 3.0; // 3.3333

            //int h = 10.0 / 3; 
            //int h = 4.6;

            int x = 10;
            int y = 3;

            double z = Convert.ToDouble(x) / y;
            double z1 = x * 1.0 / y;
        }
    }
}
