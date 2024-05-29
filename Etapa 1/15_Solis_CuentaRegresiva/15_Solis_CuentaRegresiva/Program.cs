using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Solis_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            

            Console.WriteLine("escribi un numero entero y positivo:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("te muestro la cuenta regresiva");
            while (num>=0)
            {
                Console.WriteLine(num);
                num--;
            }

            Console.ReadKey();
        }
    }
}
