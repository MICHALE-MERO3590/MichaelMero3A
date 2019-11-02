using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_POO.clases
{
    class Pract2_productoFactura
    {
        private float cantidad;
        private float pvp;
        private float subtotal;
        //private float subtotalsuma;
        private float descuento;
        private float iva;
        private float total;

        public float Cantidad
        {
            get { return cantidad; }
            set {
                if (cantidad >= 1)
                {
                    throw new Exception("La cantidad ingresada debe de ser mayor que 1 ");
                }
                cantidad = value; 
                }
        }

        public float PVP
        {
            get { return pvp; }
            set { pvp = value; }
        }

        public float Subtotal
        {
            get { return Cantidad *PVP; }
        }

        public  float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public float IVA
            {
            get { return (Subtotal*12)/100; }
        }

        public  float Total
        {
            get { return (subtotal+IVA-descuento); }
        }


        private Practica2_Factura factura;
        public Practica2_Factura Factura
        {
            get { return Factura; }
        }

        private Pactica2_Producto producto;
        public Pactica2_Producto Producto
        {
            get { return Producto; }

        }
    }
}
