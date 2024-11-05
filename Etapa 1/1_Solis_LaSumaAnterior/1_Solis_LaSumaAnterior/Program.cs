using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solis_LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, SumaTotal;

            num1 = 18;
            num2 = 2;
            num3 = 10;

            SumaTotal = num1 + num2 + num3;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + SumaTotal);

            Console.ReadKey(); 

        }
    }
}
