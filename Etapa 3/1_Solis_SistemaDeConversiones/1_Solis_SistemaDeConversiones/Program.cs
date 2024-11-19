namespace _1_Solis_SistemaDeConversiones
{
    internal class Program
    {
        static string decimales(int x)
        {
            string bin = " ";
            while (x > 0)
            {
                bin = (x % 2) + bin;
                x /= 2;
            }
            return bin;
        }
        static int binario(string x)
        {
            return Convert.ToInt32(x, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero en decimal para pasarlo a binario:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("En binario es: " + (decimales(num)));
   
            Console.WriteLine("Ingresa un numero en binario para pasarlo a decimal");
            string bin1 = Console.ReadLine();
            Console.WriteLine("En decimal es: "+(binario(bin1)));
            Console.ReadKey();
        }
    }
}
