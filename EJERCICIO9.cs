using System;

namespace Ejercicio9
{
    class EJERCICIO9
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para realizar la tabla de multiplicar: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 15; i++)
            {
                int result = num * i;
                Console.WriteLine(num + " * " + i + " = " + result);
            }
        }
    }
}
