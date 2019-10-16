using System;

namespace Ejercicio4
{
    class EJERCICIO4
    {
        static void Main(string[] args)
        {
            int uno = 1, dos;
            do
            {
                Console.Write("Ingrese horas realizadas por trabajador: ");
                int hor = Convert.ToInt32(Console.ReadLine());

                if (hor >= 35)
                {
                    Console.WriteLine("\n" + "El empledo debera cobrar horas extras");
                    double ext = hor - 35;
                    double tot = ext * 22;

                    Console.WriteLine("El empleado tien un total de " + ext + " horas extras");
                    Console.WriteLine("Debera cobrar: " + tot + " dolares de horas extras" + "\n");

                    Console.WriteLine("Desea calcular otro salario: "
                            + "\n" + "1. para salir"
                            + "\n" + "2. para continuar");
                    uno = Convert.ToInt32(Console.ReadLine());
                    if (uno != 1)
                    {
                        Console.WriteLine("\n" + "Calculemos");
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "El trabajador no cobrara horas extras" + "\n"
                                   + "\n" + "Desea calcular otro salario: "
                                   + "\n" + "1. para salir"
                                   + "\n" + "2. para continuar");
                    uno = Convert.ToInt32(Console.ReadLine());
                    if (uno != 1)
                    {
                        Console.WriteLine("\n" + "Calculemos");
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            } while (uno != 1);
        }
    }
}
