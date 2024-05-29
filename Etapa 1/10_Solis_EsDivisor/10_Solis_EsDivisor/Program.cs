using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Solis_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, divi;


            Console.WriteLine("ingresa un numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa un otro:");
            num2 = int.Parse(Console.ReadLine());

            divi = num1 / num2;

            if (num1 > 0)
            {
                Console.WriteLine("division ="+ divi);
            }
            else if (num1 == 0)
            {
                Console.WriteLine("ErRoR 0.o"); 
            }

            Console.ReadKey();
        }
    }
}
