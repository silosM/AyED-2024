Console.WriteLine("Ingrese la cantidad de candidatos que realizaron el examen: ");
int partic = int.Parse(Console.ReadLine());
int[] participantes = new int[partic];
for (int i = 0; i < partic; i++)
{
    Console.Write("Ingrese los puntajes del candidato N°" + (i + 1) + (": "));
    participantes[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < partic - 1; i++)
{
    int menor = i;
    for (int j = i + 1; j < partic; j++)
    {
        if (participantes[j] < participantes[menor])
        {
            menor = j;
        }
    }

    int temp = participantes[i];
    participantes[i] = participantes[menor];
    participantes[menor] = temp;
}

Console.Write("Ingrese un numero entero: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Los puntajes multiplos al numero " + num + " son: ");
for (int i = 0; i < partic; i++)
{
    if (participantes[i] % num == 0)
    {
        Console.WriteLine(participantes[i]);
    }

}
Console.WriteLine("Puntajes ordenados de menor a mayor:");
for (int i = 0; i < partic; i++)
{
    Console.WriteLine((i + 1) + ": " + participantes[i]);
}


Console.ReadKey();
