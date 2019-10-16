using System;

namespace Ejercicio5
{
    class EJERCICIO5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para realizar la piramide de asteriscos: ");
            int cinco = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cinco; i++)
            {
                for (int j = 1; j <= cinco - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
