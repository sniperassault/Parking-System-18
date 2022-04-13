using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
 public abstract class Alquiler
    {
      private DateTime fecha;
      private Cochera cochera;



        public Alquiler(Cochera cochera)
        {
            Cochera = cochera;
            Fecha = DateTime.Now;
        }

        public Alquiler()
        {
            
        }


        public Cochera Cochera
        {
            get
            {
                return cochera;
            }

            set
            {
                cochera = value;
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

        public abstract double CalcularImporte();
    }
}
