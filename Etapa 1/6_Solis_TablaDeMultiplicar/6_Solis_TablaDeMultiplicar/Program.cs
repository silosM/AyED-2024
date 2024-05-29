using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Solis_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;

            Console.WriteLine("dime un numero:");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("1x" + X + "=" + 1 * X);
            Console.WriteLine("2x" + X + "=" + 2 * X);
            Console.WriteLine("3x" + X + "=" + 3 * X);
            Console.WriteLine("4x" + X + "=" + 4 * X);
            Console.WriteLine("5x" + X + "=" + 5 * X);
            Console.WriteLine("6x" + X + "=" + 6 * X);
            Console.WriteLine("7x" + X + "=" + 7 * X);
            Console.WriteLine("8x" + X + "=" + 8 * X);
            Console.WriteLine("9x" + X + "=" + 9 * X);
            Console.WriteLine("10x" + X + "=" + 10 * X);
            


            Console.ReadLine();
        }
    }
}
