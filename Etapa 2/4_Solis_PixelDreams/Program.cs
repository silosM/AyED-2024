using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Solis_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos jugadores participan en el torneo?");
            int jugadores = int.Parse(Console.ReadLine());
            int[] losJugadores = new int[jugadores];


            int lista = 0;
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("¿Cuantos puntos tiene el jugador " + (i + 1)+"?");
                int puntaje = int.Parse(Console.ReadLine());
                losJugadores[i] = puntaje;
            }
            for (int i = 0; i < jugadores - 1; i++)
            {
                for (int t = 0; t < jugadores - 1; t++)
                {
                    if (losJugadores[t] < losJugadores[t + 1])
                    {
                        lista = losJugadores[t + 1];
                        losJugadores[t + 1] = losJugadores[t];
                        losJugadores[t] = lista;
                    }
                }

            }


            Console.WriteLine("Lista de los puntos de los jugadores:");
            for (int i=0;i<jugadores;i++)
            {
                Console.WriteLine("jugador "+(i+1)+ ":" +losJugadores[i]+" puntos");
            }



            Console.ReadKey();
        }
    }
}
