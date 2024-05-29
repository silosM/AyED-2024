using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Solis_DimensionesDeEsferaCorrecoin
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, radio, superficie, volumen;
            pi = 3.14;
            Console.WriteLine("decime el radio de la esfera:");
            radio = int.Parse(Console.ReadLine());
            superficie = 4 * pi * radio * radio;
            volumen = ((pi * 4)/3 * (radio*radio*radio));

            Console.WriteLine("superficie =" + superficie);
            Console.WriteLine("volumen =" + volumen);



            Console.ReadKey();
        }
    }
}
