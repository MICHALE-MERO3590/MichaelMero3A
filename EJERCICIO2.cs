using System;

namespace Ejercicio2
{
    class EJERCICIO2
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un numero para realizar un cuadrado: ");
            int dos = Convert.ToInt32(Console.ReadLine());
            if (dos == 1 || dos == 0)
            {
                Console.Write("Su cuadrado tiene dimensiones muy cortas"
                        + "\n" + "Se le agregra valores para que sea un cuadrado");

                dos = dos + 2;
            }
            else
            {
                Console.WriteLine("Su cuadrado tendra una dimension de: " + dos + "*" + dos);
            }

            for (int i = 1; i <= dos; i++)
            {
                for (int j = 1; j <= dos; j++)
                {
                    if (i == 1 || i == dos || j == 1 || j == dos)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
