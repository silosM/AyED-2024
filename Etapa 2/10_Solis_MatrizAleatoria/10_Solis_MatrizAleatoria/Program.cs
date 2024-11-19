Console.Write("Ingrese el numero de filas: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero de columnas: ");
int M = int.Parse(Console.ReadLine());
int[,] matriz = new int[N, M];
Random aleatorio = new Random();
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        matriz[i, j] = aleatorio.Next(1, 101);
    }
}
for (int fila = 0; fila < N; fila++)
{
    for (int columna = 0; columna < M; columna++)
    {
        Console.Write(matriz[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();