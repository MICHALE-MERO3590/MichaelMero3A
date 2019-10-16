using System;

namespace Ejercicio7
{
    class EJERCICIO7
    {
        static void Main(string[] args)
        {
            int a = 0, b = 101;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}   {1}", a = a + 1, b = b - 1);
            }
        }
    }
}
