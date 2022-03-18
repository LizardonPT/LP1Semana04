using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um número positivo: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            int fibnumb = Fibonacci(pos);

            Console.WriteLine($"O número de Fibonacci na posição {pos} é igual"
            +$" a {fibnumb}");
        }

        private static int Fibonacci(int n)
        {
            int valor;
            if (n == 1 || n == 2)
            {
                valor = 1;
            }
            
            else
            {
                valor = Fibonacci(n-2) + Fibonacci(n-1);
            }
            
            return valor;
        }
    }
}
