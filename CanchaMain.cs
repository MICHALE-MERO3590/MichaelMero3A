using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioCancha.Clase;

namespace EjercicioCancha
{
    class CanchaMain
    {
        static void Main(string[] args)
        {
            Cancha1 canchita = new Cancha1();

            canchita.Cancha = "Futbol";
            Console.WriteLine(canchita.Cancha);
            canchita.Costo = 50;
            Console.WriteLine(canchita.Costo);
            canchita.Horas = 2;
            Console.WriteLine("Horas de alquiler de cancha: " + canchita.Horas);

            Console.WriteLine("El subtotal a pagar es: " + canchita.SubTotal1);

            canchita.Descuento = 10;
            Console.WriteLine("El descuento es: "+ canchita.Descuento);
            Console.WriteLine("El subtotal a pagar es: " + canchita.SubTotal2);
            Console.WriteLine("El total del iva a pagar es: " + canchita.Iva);
            Console.WriteLine("El valor a pagar final es: "+ canchita.Final);
            Console.WriteLine("El valor pagado es: " + canchita.Pagado);
            Console.WriteLine("El valor pendiente es: " +canchita.Pendiente);

            canchita.Estado = "";
            Console.WriteLine("Estado de la cuota: " + canchita.Estado);


            Console.ReadLine();
        }
    }
}
