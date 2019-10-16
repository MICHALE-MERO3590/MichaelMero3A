using System;

namespace Ejercicio6
{
    class EJERCICIO6
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para realizar la piramide de asteriscos: ");
            int seis = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= seis; i++)
            {
                for (int j = 1; j <= seis - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = seis; i >= 1; i--)
            {
                for (int j = seis - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = (i * 2) - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
