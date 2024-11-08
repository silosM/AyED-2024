using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Solis_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos objetos quieres analizar?");
            int objeto = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el valor minimo de los objetos?");
            int ValMini = int.Parse(Console.ReadLine());

            //Array, aqui le ingreso uno por uno el precio de cada objeto
            int[] Objetos = new int[objeto];
            
            for (int i=0; i<objeto;i++)
            {
                Console.WriteLine("Ingresa el valor del objeto "+(i+1));
                //se cambia la cantidad de objetos por la variable i
                //y en cada espacio se va ingresando el valor de un bjeto
                Objetos[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Los Objetos que buscas son:");
            for (int i = 0; i <objeto;i++)
            {
                if (Objetos[i]>ValMini)
                {
                    Console.WriteLine("Objeto N°"+(i+1)+": "+Objetos[i]);
                }
            }



            Console.ReadKey();
        }
    }
}
