using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Solis_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos examenes son?");
            int examenes = int.Parse(Console.ReadLine());
            int[] LosExamenes = new int[examenes];

            Console.WriteLine("Cuantos Tps son?");
            int trabajos = int.Parse(Console.ReadLine());
            int[] LosTrabajos = new int[trabajos];

            int[] notaexamen = new int[examenes];
            int promedio = 0;
            for (int i = 0; i < examenes; i++)
            {
                Console.WriteLine("Cuanto te sacaste en el Examen " + (i + 1) + " del 1 al 10");
                notaexamen[i] = int.Parse(Console.ReadLine());

                promedio = notaexamen[i] + promedio;
            }

            if (promedio / examenes >= 6)
            {
                Console.WriteLine("examenes aprobados");
                Console.WriteLine("");
            }
            else if (promedio / examenes < 6)
            {
                Console.WriteLine("examenes no aprobados");
                Console.WriteLine("");
            }

            int promediotp = 0;
            int[] notatp = new int[trabajos];

            for (int i = 0; i < trabajos; i++)
            {
                Console.WriteLine("Cuanto te sacaste en el Tp" + (i + 1) + " del 1 al 10");
                notatp[i] = int.Parse(Console.ReadLine());

                promediotp = notatp[i] + promediotp;
            }
            if (promediotp / (trabajos * 0.75) > 6)
            {
                Console.WriteLine("Trabajos Practicos Aprobados");
            }
            else
            {
                Console.WriteLine("Trabajos Practicos Desaprobados");
            }



            Console.ReadKey();
        }
    }
}
