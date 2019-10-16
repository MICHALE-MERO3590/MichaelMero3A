using System;

namespace Ejercicio1
{
    class EJERCICIO1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int uno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            int dos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            int tres = Convert.ToInt32(Console.ReadLine());

            if (uno < dos && uno < tres)
            {
                Console.Write("El numero menor es: " + uno);
            }

            else if (dos < uno && dos < tres)
            {
                Console.WriteLine("El numero menor es: " + dos);
            }

            else
            {
                Console.WriteLine("El numero menor es: " + tres);
            }
        }
    }
}
