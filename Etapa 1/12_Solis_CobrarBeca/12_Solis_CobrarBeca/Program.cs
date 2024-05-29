using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Solis_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;

            Console.WriteLine("Veremos si podes cobrar la beca");
            Console.WriteLine("cuantps años tienes?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos ingresos tienes?");
            ingresos = int.Parse(Console.ReadLine());

            if (edad >= 19 & ingresos >= 100000)
            {
                Console.WriteLine("puedes cobrar la beca crack");
            }
            else
            {
                Console.WriteLine("NO PUEDES, maldito pobre");
            }

            Console.ReadKey();
        }
    }
}
