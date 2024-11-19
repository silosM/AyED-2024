Console.WriteLine("Ingrese el número de estudiantes:");
int Num = int.Parse(Console.ReadLine());
object[,] Estu = new object[Num, 3];
for (int i = 0; i < Num; i++)
{
    Console.WriteLine("Ingrese los datos del estudiante" + (i + 1) + ":");

    Console.Write("Nombre: ");
    Estu[i, 0] = Console.ReadLine();

    Console.Write("Edad: ");
    Estu[i, 1] = int.Parse(Console.ReadLine());

    Console.Write("Calificación: ");
    Estu[i, 2] = double.Parse(Console.ReadLine());
}
Console.WriteLine("\nInformación de los estudiantes:\n");
Console.WriteLine("Nombre\tEdad\tCalificación");
for (int i = 0; i < Num; i++)
{

    for (int j = 0; j < 3; j++)
    {
        Console.Write(Estu[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();