using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioCancha.Clase
{
    class Cancha1
    {
        private string cancha, estado;
        private float costo;
        private int horas;
        private float subtotal1;
        private float descuento;
        private float subtotal2;
        private float iva;
        private float final;
        private float pagado;
        private float pendiente;

        public string Cancha
        {
            get { return cancha; }
            set
            {
                if (value == "Futbol")
                    cancha = value;
                if (value == "Fulbito")
                    cancha = value;
                if (value == "Indor")
                    cancha = value;
                if (value == "Basquet")
                    cancha = value;
            }
        }

        public float Costo
        {
            get { return costo; }
            set
            {
                if (cancha == "Futbol")
                    costo = 20;
                if (cancha == "Fulbito")
                    costo = 15;
                if (cancha == "Indor")
                    costo = 5;
                if (cancha == "Basquet")
                    costo = 5;
            }
        }

        public int Horas
        {
            get { return horas; }
            set
            {
                if (value > 3)
                {
                    throw new Exception("No se puede alquilar por mas de tres horas");
                }
                horas = value;
            }
        }

        public float SubTotal1
        {
            get { return horas * costo; }
        }
        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value == 10)
                {
                    descuento = (SubTotal1 * 10) / 100;
                }
                if (value == 20)
                {
                    descuento = (SubTotal1 * 20) / 100;
                }
                if (value == 0)
                    Console.WriteLine("No hay descuento");
            }
        }

        public float SubTotal2
            {
            get { return SubTotal1 - Descuento; }
            }

        public float Iva
        {
            get { return (SubTotal2 * 12) / 100;  }
           
        }

            public float Final
        {
            get { return Iva + SubTotal2;  }
        }
        
        public float Pagado
        {
            get { return (Final * 70) / 100; }
        }

        public float Pendiente
        {
            get { return Final - Pagado; }
        }
        public string Estado
        {
            get { return estado; }
            set
            {
                if (pendiente <= 0)
                {
                    estado = "Pagado";
                }
                else
                {
                    estado = "Pendiente";
                }
            }
               
        }
    }
}
