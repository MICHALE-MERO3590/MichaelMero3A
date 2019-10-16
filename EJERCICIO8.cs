using System;

namespace Ejercicio8
{
    class EJERCICIO8
    {
        static void Main(string[] args)
        {
            int a = 0, b = -2, c = -3;
            Console.Write("Ingrese un numero: ");
            int ocho = Convert.ToInt32(Console.ReadLine());
            if (ocho > 0)
            {
                for (int i = 0; i <= ocho; i++)
                {
                    Console.WriteLine("{0}   {1}   {2}", a++, b = b + 2, c = c + 3);
                }
            }
            else
            {
                Console.WriteLine("El programa no se ejecutara por numero negativo");
            }
        }
    }
}
