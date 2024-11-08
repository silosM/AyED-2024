using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_SolisYCarita_Pochimons
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int conteo = 0;
            int MaxP = 75;
            string[,] pochidex = new string[MaxP, 5];
            while (opcion != 9)
            {
                Console.Write("-----------------------------------------------------\nMenú Principal - Centro de Investigación de Pochimons\n-----------------------------------------------------\n");
                Console.WriteLine("Pochimones Encontrados: " + conteo + "/" + MaxP + "\n");
                Console.WriteLine("1- Registrar Pochimon ");
                Console.WriteLine("2- Asignar Investigador a Pochimon ");
                Console.WriteLine("3- Actualizar Nivel de Pochimon ");
                Console.WriteLine("4- Marcar Pochimon como Investigado ");
                Console.WriteLine("5- Mostrar Información de Pochimons ");
                Console.WriteLine("6- Buscar Pochimons por Tipo ");
                Console.WriteLine("7- Mostrar Pochimons por Investigador ");
                Console.WriteLine("8- Mostrar Pochimons Picados ");
                Console.WriteLine("9- Salir ");
                Console.Write("-----------------------------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese la opción deseada:");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        if (conteo == MaxP)
                        {
                            Console.WriteLine("La Pochidex está llena.");
                            break;
                        }

                        Console.Write("Ingrese el nombre del Pochimon: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el tipo del Pochimon (Agua/Fuego/Planta): ");
                        string tipo = Console.ReadLine();
                        Console.Write("Ingrese el nivel del Pochimon: ");
                        string nivel = Console.ReadLine();


                        while (conteo < MaxP)
                        {


                            pochidex[conteo, 0] = nombre;
                            pochidex[conteo, 1] = tipo;
                            pochidex[conteo, 2] = nivel;
                            pochidex[conteo, 3] = "0"; //estado,,
                            pochidex[conteo, 4] = "0"; //investigador,,
                            conteo++;
                            Console.WriteLine("Pochimon registrado exitosamente.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }
                        break;
                }
    }
}
