using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_POO.clases
{
    class Practica2_Factura
    {
        private int numero;
        private DateTime fecha;
        private float subtotal;
        private float descuento;
        private float iva;
        private float total;

        public int Numero
        {
            get { return numero; }
            set
            {
                if (value <= 1 && value >= 20)
                {
                    throw new Exception("El numero del producto facturado no debe ser menor a 1 o mayor a 20 ");

                }
                numero = value;
            }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public float DescTot
        {
            get { return Subtotal - Descuento; }
        }

        public float IVA
        {
            get { return (DescTot * 12) / 100; }
        }

        public float Total
        {
            get { return (DescTot + subtotal) + IVA; }
        }

        private List<Practica2_Cliente> listacliente;
        
        public List<Practica2_Cliente> ListaCliente
        {
            get { return listacliente; }
            set { listacliente = value; }
        }

        private List<Pract2_productoFactura> listaproductoFactura;

        public List<Pract2_productoFactura> ListaProductoFactura
        {
            get { return listaproductoFactura; }
            set { listaproductoFactura = value; }
        }
    }
}