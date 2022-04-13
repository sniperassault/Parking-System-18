using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class Cierre
    {
       private DateTime fecha;
       private Usuario usuario;

        public Cierre(DateTime fecha, Usuario usuario)
        {
            this.fecha = fecha;
            this.usuario = usuario;
        }

        public Cierre()
        {
            
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
    }
}
