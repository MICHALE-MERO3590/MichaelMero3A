using System;

namespace Ejercicio10
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            int diez;
            do
            {
                Console.WriteLine("MENU DE OPERACIONES."
                    + "\n" + "1. Salir"
                    + "\n" + "2. Sumatorio"
                    + "\n" + "3. Factorial");

                Console.WriteLine("");
                Console.Write("Escoja una opcion: ");
                diez = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (diez)
                {
                    case 1:
                        Console.WriteLine("Usted ha escogido la opcion 1"
                                + "\n" + "La cual indica salida del programa");
                        Environment.Exit(0);
                        break;

                    case 2:
                        Console.WriteLine("2. SUMATORIO");

                        int sumatoria = 1;

                        Console.Write("Ingrese un numero para encontar su sumatoria: ");
                        int numer = Convert.ToInt32(Console.ReadLine());

                        for (int i = numer; i > 0; i--)
                        {
                            sumatoria = sumatoria + i;
                        }
                        Console.Write("El sumatoria de " + numer + " es: " + (sumatoria-1));
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine("3. FACTORIAL");

                        int factorial = 1;

                        Console.Write("Ingrese un numero para encontar su factorial: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        for (int i = numero; i > 0; i--)
                        {
                            factorial = factorial * i;
                        }
                        Console.Write("El factorial de " + numero + " es: " + factorial);
                        Console.WriteLine("\n");
                        break;
                }
            } while (diez != 0);
        }
    }
}
