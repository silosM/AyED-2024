Console.Write("Ingrese el numero de filas de la matriz: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Ingrese el numero de columnas de la matriz: ");
int M = int.Parse(Console.ReadLine());
int[,] matriz = new int[N, M];
for (int fila = 0; fila < N; fila++)
{
    for (int columna = 0; columna < M; columna++)
    {
        matriz[fila, columna] = 0;
        Console.Write(matriz[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();
