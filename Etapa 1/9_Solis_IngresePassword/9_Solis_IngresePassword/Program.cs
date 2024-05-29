using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Solis_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña, inten;
            contraseña = "el pepo";


            Console.WriteLine("cual es la contra?");
            inten = Console.ReadLine();

            if (contraseña == inten)
            {
                Console.WriteLine("Correcto");
            }
            else
            {
                Console.WriteLine("Incorrecto");
            }


            Console.ReadKey();
        }
    }
}
