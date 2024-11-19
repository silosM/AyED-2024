Console.Write("Ingrese el tamaño de la matriz: ");
int N = int.Parse(Console.ReadLine());

int[,] Matriz = new int[N, N];
int[] Diagonal = new int[N];
Random Aleatorio = new Random();
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Matriz[i, j] = Aleatorio.Next(1, 101);
    }
}
for (int i = 0; i < N; i++)
{
    Diagonal[i] = Matriz[i, i];
}

Console.WriteLine("Matriz generada:");
for (int fila = 0; fila < N; fila++)
{
    for (int columna = 0; columna < N; columna++)
    {

        Console.Write(Matriz[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nDiagonal principal:");
for (int i = 0; i < N; i++)
{
    Console.Write(Diagonal[i] + "\t");
}
Console.ReadKey();
