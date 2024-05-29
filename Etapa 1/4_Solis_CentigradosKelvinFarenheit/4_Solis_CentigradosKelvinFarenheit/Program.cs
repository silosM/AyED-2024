using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Solis_CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel, fahren, kel;
            Console.WriteLine("cuantos grados hace?, lo pasare a kelvin y fahrenheit");

            cel = int.Parse(Console.ReadLine());

            kel = 273 + cel;
            fahren = cel * 18 / 10 + 32;
            Console.WriteLine("kelvin = " + kel);
            Console.WriteLine("fahrenheit = " + fahren);



            Console.ReadKey(); 
        }
    }
}
