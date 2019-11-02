using System;
using System.Collections.Generic;
using System.Text;

using Tarea2_POO.clases;

namespace Tarea2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Practica2_Cliente cliente = new Practica2_Cliente();
            Practica2_Factura factura = new Practica2_Factura();
            Pactica2_Producto producto = new Pactica2_Producto();
            Pract2_productoFactura profact = new Pract2_productoFactura();
            
            
            Console.WriteLine("Ingrese su identificacion");
            cliente.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            cliente.Telefono = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese nombre del cliente:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese codigo del producto:");
            producto.Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese descripcion del producto:");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad :");
            profact.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio :");
            profact.PVP = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el descuento :");
            profact.Descuento = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine(" Subtotal: " + profact.Subtotal);
            //Console.WriteLine(" Subtotal-descuento: " + profact.SubtotalSuma);
            Console.WriteLine(" Iva: " + profact.IVA);
            Console.WriteLine(" Total: " + profact.Total);
            Console.ReadLine();

            //Cliente cliente = new Cliente("1315", "Jose", "Manta", 0999);

            Console.ReadLine();
        }
    }
}
