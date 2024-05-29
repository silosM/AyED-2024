using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Solis_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cuantas vueltas va a dar el Rayo Macqueen?");
            int vueltas = int.Parse(Console.ReadLine());
            

            int[] Eltiempo = new int[vueltas];
            int record = 1000000000;
            int tiempo = 0;
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine("Cuantos segundos tardo en dar la vuelta N°" + (i + 1));
                Eltiempo[i] = int.Parse(Console.ReadLine());

                if (Eltiempo[i] < record)
                {
                    record = Eltiempo[i];
                }
                tiempo = tiempo + Eltiempo[i];
            }
            Console.WriteLine("Tiempo total: "+tiempo+" segundos");
            Console.WriteLine("Promedio del tiempo de las vueltas: "+(tiempo/vueltas)+" segundos");
            Console.WriteLine("La mejor vuelta: " + record+ " segundos");


            Console.ReadKey();
        }
    }
}
