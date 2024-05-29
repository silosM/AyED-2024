using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa la cantidad de obstáculos.");
            int obstaculos = int.Parse(Console.ReadLine());

            int[] LosObstaculos = new int[obstaculos];

            string respuesta;
            int puntos = 0;

            for (int i = 0; i < obstaculos; i++)
            {
                Console.WriteLine("Homero pasa el " + (i+1) + " Si o No?");
                respuesta = Console.ReadLine();

                if (respuesta == "Si")
                {
                    LosObstaculos[i] = 10;
                }
                else if (respuesta == "No")
                {
                    LosObstaculos[i] = -5;
                }
                else if (respuesta != "No" || respuesta != "Si")
                {
                    Console.WriteLine("Homero pasa el " + (i+1) + " Si o No?");
                    respuesta = Console.ReadLine();
                }
                puntos = puntos + LosObstaculos[i];
            }

            Console.WriteLine("Homero tiene " + puntos + " puntos");

            Console.ReadKey();
        }
    }
}
