namespace _3_Solis_PochimonsFuncionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int conteo = 0;
            int MaxP = 75;
            string[,] pochidex = new string[MaxP, 5];

            while (opcion != 9)
            {
                MostrarMenu(conteo, MaxP);
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                EjecutarOpcion(opcion, ref conteo, MaxP, ref pochidex);
            }
            Console.WriteLine("Hasta Luego");
            Console.ReadKey();
        }

        static void MostrarMenu(int conteo, int MaxP)
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
        }

        static void EjecutarOpcion(int opcion, ref int conteo, int MaxP, ref string[,] pochidex)
        {
            switch (opcion)
            {
                case 1:
                    RegistrarPochimon(ref conteo, MaxP, ref pochidex);
                    break;
                case 2:
                    AsignarInvestigador(conteo, MaxP, ref pochidex);
                    break;
                case 3:
                    ActualizarNivel(conteo, MaxP, ref pochidex);
                    break;
                case 4:
                    MarcarComoInvestigado(conteo, MaxP, ref pochidex);
                    break;
                case 5:
                    MostrarInformacion(conteo, ref pochidex);
                    break;
                case 6:
                    BuscarPorTipo(conteo, ref pochidex);
                    break;
                case 7:
                    MostrarPorInvestigador(conteo, ref pochidex);
                    break;
                case 8:
                    MostrarPochimonsPicados(conteo, ref pochidex);
                    break;
                case 9:
                    Console.WriteLine("9- Salir ");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void RegistrarPochimon(ref int conteo, int MaxP, ref string[,] pochidex)
        {
            if (conteo == MaxP)
            {
                Console.WriteLine("La Pochidex está llena.");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.Write("Ingrese el nombre del Pochimon: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
            string tipo = Console.ReadLine();
            Console.Write("Ingrese el nivel del Pochimon: ");
            string nivel = Console.ReadLine();

            pochidex[conteo, 0] = nombre;
            pochidex[conteo, 1] = tipo;
            pochidex[conteo, 2] = nivel;
            pochidex[conteo, 3] = "0"; // estado
            pochidex[conteo, 4] = "0"; // investigador
            conteo++;
            Console.WriteLine("Pochimon registrado exitosamente.");
            Console.ReadLine();
            Console.Clear();
        }

        static void AsignarInvestigador(int conteo, int MaxP, ref string[,] pochidex)
        {
            int conteo4 = 0;
            Console.WriteLine("Pochimons no investigados:");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
            while (conteo4 < conteo)
            {
                if (pochidex[conteo4, 3] != "1" && pochidex[conteo4, 3] != "2")
                {
                    Console.WriteLine("|" + conteo4 + "\t| " + pochidex[conteo4, 0] + "\t|" + pochidex[conteo4, 1] + "\t|" + pochidex[conteo4, 2] + "\t|" + pochidex[conteo4, 3] + "\t|" + pochidex[conteo4, 4] + "\t|");
                }
                conteo4++;
            }

            Console.Write("Ingrese el número de fila del Pochimon a asignar: ");
            int fila2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el código del Investigador: ");
            string investigador = Console.ReadLine();

            if (fila2 < MaxP)
            {
                pochidex[fila2, 4] = investigador;
                pochidex[fila2, 3] = "1";
                Console.WriteLine("Investigador asignado exitosamente.");
            }
            else
            {
                Console.WriteLine("Fila no válida o Pochimon ya investigado.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void ActualizarNivel(int conteo, int MaxP, ref string[,] pochidex)
        {
            int conteo3 = 0;
            Console.WriteLine("Pochimons registrados:");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|");
            while (conteo3 < conteo)
            {
                Console.WriteLine("|" + conteo3 + "\t| " + pochidex[conteo3, 0] + "\t|" + pochidex[conteo3, 1] + "\t|" + pochidex[conteo3, 2] + "\t|");
                conteo3++;
            }

            Console.Write("Ingrese el número de fila del Pochimon a actualizar: ");
            int fila = int.Parse(Console.ReadLine());

            if (fila < MaxP)
            {
                Random level = new Random();
                int incremento = level.Next(1, 3);

                pochidex[fila, 2] = (int.Parse(pochidex[fila, 2]) + incremento).ToString();
                Console.WriteLine("Nivel actualizado exitosamente. Ahora es nivel " + pochidex[fila, 2]);
            }
            else
            {
                Console.WriteLine("Fila no válida.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void MarcarComoInvestigado(int conteo, int MaxP, ref string[,] pochidex)
        {
            int conteo5 = 0;
            Console.WriteLine("Pochimons siendo investigados:");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
            while (conteo5 < conteo)
            {
                if (pochidex[conteo5, 3] == "1")
                {
                    Console.WriteLine("|" + conteo5 + "\t|" + pochidex[conteo5, 0] + "\t|" + pochidex[conteo5, 1] + "\t|" + pochidex[conteo5, 2] + "\t|" + pochidex[conteo5, 3] + "\t|" + pochidex[conteo5, 4] + "\t|");
                }
                conteo5++;
            }

            Console.Write("Ingrese el número de fila del Pochimon que ha sido Investigado: ");
            int fila3 = int.Parse(Console.ReadLine());

            if (fila3 < MaxP)
            {
                pochidex[fila3, 3] = "2";
                Console.WriteLine("Quedó registrado exitosamente.");
            }
            else
            {
                Console.WriteLine("Fila no válida.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void MostrarInformacion(int conteo, ref string[,] pochidex)
        {
            int conteo2 = 0;
            Console.WriteLine("5- Mostrar Información de Pochimons \n");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
            while (conteo2 < conteo)
            {
                Console.WriteLine("|" + conteo2 + "\t| " + pochidex[conteo2, 0] + "\t|" + pochidex[conteo2, 1] + "\t|" + pochidex[conteo2, 2] + "\t|" + pochidex[conteo2, 3] + "\t|" + pochidex[conteo2, 4] + "\t|");
                conteo2++;
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void BuscarPorTipo(int conteo, ref string[,] pochidex)
        {
            int conteo6 = 0;
            Console.WriteLine("Ingrese el tipo de Pochimon a buscar (A/F/P):");
            string tipos = Console.ReadLine();
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
            while (conteo6 < conteo)
            {
                if (pochidex[conteo6, 1] == tipos)
                {
                    Console.WriteLine("|" + conteo6 + "\t| " + pochidex[conteo6, 0] + "\t|" + pochidex[conteo6, 1] + "\t|" + pochidex[conteo6, 2] + "\t|" + pochidex[conteo6, 3] + "\t|" + pochidex[conteo6, 4] + "\t|");
                }
                conteo6++;
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void MostrarPorInvestigador(int conteo, ref string[,] pochidex)
        {
            int conteo7 = 0;
            Console.WriteLine("Ingrese el código del Investigador: ");
            string inve = Console.ReadLine();
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|Investigador Asignado\t|");
            while (conteo7 < conteo)
            {
                if (pochidex[conteo7, 4] == inve)
                {
                    Console.WriteLine("|" + conteo7 + "\t| " + pochidex[conteo7, 0] + "\t|" + pochidex[conteo7, 1] + "\t|" + pochidex[conteo7, 2] + "\t|" + pochidex[conteo7, 3] + "\t|" + pochidex[conteo7, 4] + "\t|");
                }
                conteo7++;
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void MostrarPochimonsPicados(int conteo, ref string[,] pochidex)
        {
            int conteo8 = 0;
            Console.WriteLine("Pochimons picados: ");
            Console.WriteLine("|Fila\t|Nombre\t|Tipo\t|Nivel\t|");
            while (conteo8 < conteo)
            {
                if (int.Parse(pochidex[conteo8, 2]) >= 30)
                {
                    Console.WriteLine("|" + conteo8 + "\t| " + pochidex[conteo8, 0] + "\t|" + pochidex[conteo8, 1] + "\t|" + pochidex[conteo8, 2] + "\t|");
                }
                conteo8++;
            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}
