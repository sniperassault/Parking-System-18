using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class Movimiento
    {
        private string concepto;
        private double importe;
        private DateTime fecha;
        private bool esIngreso;
        private Usuario usuario;
        private Cierre cierre;



        public Movimiento()
        {
            
        }

        public Movimiento(string concepto, double importe,bool esIngreso, Usuario usuario)
        {
            this.concepto = concepto;
            this.importe = importe;
            Fecha = DateTime.Now;
            this.esIngreso = esIngreso;
            this.usuario = usuario;
           
        }

        public string Concepto
        {
            get
            {
                return concepto;
            }

            set
            {
                concepto = value;
            }
        }

        public double Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public bool EsIngreso
        {
            get
            {
                return esIngreso;
            }

            set
            {
                esIngreso = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public Cierre Cierre
        {
            get
            {
                return cierre;
            }

            set
            {
                cierre = value;
            }
        }
    }
}
