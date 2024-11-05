using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Solis_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumA, NumB;
            /*
             Escribe un programa en C# que calcule el resultado de 
             sumar, restar, multiplicar y dividir
             dos números introducidos por el usuario.
             Además también debería calcular 
             el resto de la división en la última linea.
            */

            Console.WriteLine("Dame un numero entero:");
            //int.Parse(Console.ReadLine()); permite que el usuario ponga un num y la compu lo lea
            NumA = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame un numero enteros");
            NumB = int.Parse(Console.ReadLine());

            int suma = NumA + NumB;
            int resta = NumA - NumB;
            int multiplicacion = NumA * NumB;
            int division = NumA / NumB;
            int resto = NumA % NumB;

            Console.WriteLine(NumA + "+" + NumB + "=" + suma);
            Console.WriteLine(NumA + "-" + NumB + "=" + resta);
            Console.WriteLine(NumA + "*" + NumB + "=" + multiplicacion);
            Console.WriteLine(NumA + "/" + NumB + "=" + division);
            Console.WriteLine(NumA + "%" + NumB + "=" + resto);

            Console.ReadKey();
        }
    }
}
