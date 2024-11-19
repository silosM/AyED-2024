Random aleatorio = new Random();
Console.WriteLine("Ingrese el tamaño del vector: ");
int N = int.Parse(Console.ReadLine());
int[] vector = new int[N];

for (int i = 0; i < N; i++)
{
    vector[i] = aleatorio.Next(0, 1000);
}
bool continuar = true;
while (continuar)
{
    Console.Clear();
    Console.WriteLine("------------------------MENU--------------------------");
    Console.WriteLine("1. Imprime en pantalla todos los elementos del vector.");
    Console.WriteLine("2. Buscar numero.");
    Console.WriteLine("3. Vector de forma ascendente o descendente.");
    Console.WriteLine("4. Termina la ejecución del programa.");
    Console.Write("Seleccione una opcion: ");
    int opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Elementos del vector:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vector[i]);
            }
            break;

        case 2:

            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            bool encontrar = false;

            for (int i = 0; i < vector.Length; i++)
            {
                if (numero == vector[i])
                {
                    Console.WriteLine("El número se encuentra en la posición " + i);
                    encontrar = true;
                    break;
                }
            }
            if (!encontrar)
            {
                Console.WriteLine("El número no se encuentra en el vector.");
            }
            break;

        case 3:
            Console.WriteLine("1. Ascendente \n2. Descendente ");
            Console.WriteLine("Seleccione una opcion: ");
            int AsODe = int.Parse(Console.ReadLine());

            if (AsODe == 1)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = 0; j < N - 1; j++)
                    {
                        if (vector[j] > vector[j + 1])
                        {
                            int temp = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(vector[i]);
                }
            }
            else if (AsODe == 2)
            {
                for (int i = 0; i <= N - 1; i++)
                {
                    for (int j = 0; j < N - 1; j++)
                    {
                        if (vector[j] < vector[j + 1])
                        {
                            int temp = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(vector[i]);
                }
            }
            break;
        case 4:
            continuar = false;
            Console.WriteLine("Salir");
            break;
    }
    Console.ReadKey();