int[,] M1 = new int[3, 3];
int[,] M2 = new int[3, 3];
int[,] M3 = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Ingrese el valor de la matriz A: ");
        M1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ingreso de datos Matriz B: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Ingrese los valores: ");
        M2[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("\n");
Console.WriteLine("Suma de matrices");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        M3[i, j] = M1[i, j] + M2[i, j];
    }
}
Console.Clear();
Console.WriteLine("Los valores de la matriz A:");
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {

        Console.Write(M1[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Los valores de la matriz B:");
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {

        Console.Write(M2[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("La suma de las matrices A y B: ");
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {

        Console.Write(M3[fila, columna] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();
