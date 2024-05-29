using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Solis_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int invitados;
            Console.WriteLine("ingresa la cantidad de invitados");
            invitados = int.Parse(Console.ReadLine());
            int[] losInvitados = new int[invitados];

            int comida = 0;
            bool bucle=true;

            for (int i=0;i<invitados;i++)
            {
                while (bucle)
                {
                    Console.WriteLine("Cuanto va a comer el invitado " + (i + 1) + " del 1 al 100?");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad < 1 || cantidad > 100)
                    {
                        bucle = true;
                    }
                    else if (cantidad>1||cantidad<100)
                    {
                        bucle = false;
                        losInvitados[i] = cantidad;
                    }
                }
                bucle = true;
                    comida = comida + losInvitados[i];
                }
            Console.WriteLine("El promedio de lo que comera cada uno es:"+(comida/invitados));
            Console.ReadKey();
        }
    }
}
