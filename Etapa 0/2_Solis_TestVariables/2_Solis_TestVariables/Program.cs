using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Solis_TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos el nombre de las variables
            String cadena;
            int entero;
            bool boolean;
            float flotante;
            double doble;
            char caracter;

            //le damos el mismo valor a cada una de las variables
            cadena = "15.557294";
            entero = 15;
            boolean = false;
            flotante = 15.557294f;
            doble = 15.557294;
            caracter = '1';


            //aqui les damos la orden a la computadora que las escriba
            Console.WriteLine("String: " + cadena);
            Console.WriteLine("int: " + entero);
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("bool: " + boolean);
            Console.WriteLine("float: " + flotante);
            Console.WriteLine("double: " + doble);
            Console.WriteLine("char: " + caracter);

            /*esta linea de codigo siempre tiene que ir al final
            para que todo pueda funcionar correctamente
            */
            Console.ReadLine();
        }
    }
}
