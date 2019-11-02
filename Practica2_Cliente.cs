using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_POO.clases
{
    class Practica2_Cliente
    {

        private string direccion;
        private string nombre;
        private string identificacion;
        private int telefono;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private List<Practica2_Factura> listafactura;

        /*public Cliente(string direccion, string nombre, string identificacion, int telefono)
        {
            Direccion = direccion;
            Nombre = nombre;
            Identificacion = identificacion;
            Telefono = telefono;
        }*/

        public List<Practica2_Factura> ListaFactura
        {
            get { return listafactura; }
        }
    }
}
