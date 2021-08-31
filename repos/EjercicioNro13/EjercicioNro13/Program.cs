using System;

namespace EjercicioNro13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string retorno;

            Console.Write("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());
            retorno = Conversor.DecimalBinario(num);
            Console.WriteLine("El numero en binario es: {0} ", retorno);


            string bin;
            int retornoNum;
            Console.Write("Ingrese un numero binario: ");
            bin = Console.ReadLine();
            retornoNum = Conversor.BinarioDecimal(bin);
            Console.WriteLine("El numero en binario es: {0} ", retornoNum);
            Console.ReadKey();
        }
    }
}
