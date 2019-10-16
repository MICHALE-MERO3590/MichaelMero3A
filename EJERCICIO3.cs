using System;

namespace Ejercicio3
{
    class EJERCICIO3
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos articulos desea comprar: ");
            int tres = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if (tres != 0)
            {
                for (int i = 1; i <= tres; i++)
                {
                    Console.Write("Ingrese nombre del articulo: ");
                    String detll = Console.ReadLine();
                    Console.Write("Cuantas " + detll + " desea llevar: ");
                    int cant = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese Valor Unitario del articulo: ");
                    double vu = Convert.ToDouble(Console.ReadLine());

                    double sub = cant * vu;
                    double iva = (sub * 12) / 100;
                    double tot = sub + iva;

                    Console.WriteLine("Valor Subtototal: $" + sub);
                    Console.WriteLine("Iva: $" + iva);
                    Console.WriteLine("Valor Total: $" + tot);

                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Las compras no se realizaran por articulo a comprar de $0");
            }
        }
    }
}
