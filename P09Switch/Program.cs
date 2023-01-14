using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj cyfre");
            int cyfra = Convert.ToInt32(Console.ReadLine());

            if (cyfra == 1) 
                Console.WriteLine("jeden");
            else if (cyfra==2)
                Console.WriteLine("dwa");
            else if (cyfra == 3)
                Console.WriteLine("trzy");
            else if (cyfra == 4)
                Console.WriteLine("cztrey");
            else
                Console.WriteLine("inna");


            switch (cyfra)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                case 4:
                    Console.WriteLine("cztery");
                    break;
                default:
                    Console.WriteLine("inna");
                    break;
            }


            if (cyfra == 1)
                Console.WriteLine("jeden");
            if (cyfra == 2)
                Console.WriteLine("dwa");
            if (cyfra == 3)
                Console.WriteLine("trzy");
            if (cyfra == 4)
                Console.WriteLine("cztrey");
            else
                Console.WriteLine("inna");



        }
    }
}
