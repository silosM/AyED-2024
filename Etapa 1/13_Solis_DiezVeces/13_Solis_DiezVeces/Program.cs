using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Solis_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador;
            contador = 0;
            Console.WriteLine("dame un palabra y te la dire 10 veces");
            palabra = Console.ReadLine();

            Console.WriteLine("aqui tienes");


            while (contador < 10)
            {
             Console.WriteLine(palabra);
             contador++;
            }
            

            Console.ReadKey();
        }
    }
}
