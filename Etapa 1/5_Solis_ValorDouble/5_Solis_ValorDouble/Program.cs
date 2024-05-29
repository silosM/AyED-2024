using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Solis_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, ancho, peri, area, diag;

            Console.WriteLine("escribe la altura de tu rectangulo:");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora el ancho:");
            ancho = int.Parse(Console.ReadLine());

            peri = (altura * 2) + (ancho * 2);
            area = ancho * altura;
            diag = Math.Sqrt((ancho * ancho) + (altura * altura));

            Console.WriteLine("perimetro =" + peri);
            Console.WriteLine("area =" + area);
            Console.WriteLine("diagonal =" + diag);



            Console.ReadKey();
        }
    }
}
