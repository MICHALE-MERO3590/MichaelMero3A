using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_POO.clases
{
    class Pactica2_Producto
    {

        private string codigo;
        private string descripcion;
        private float precio;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private Pract2_productoFactura producto_factura;
        public Pract2_productoFactura ProductoFactura
        {
            get { return producto_factura; }
        }
        
       /*private List<productoFactura> listafactura;

        public List<productoFactura> Listafactura
        {
            get { return listafactura; }
            set { listafactura = value; }

        }*/
    }
}
