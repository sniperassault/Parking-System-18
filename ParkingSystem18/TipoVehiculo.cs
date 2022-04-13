using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class TipoVehiculo
    {
        private string codigo;
        private string descripcion;

        public TipoVehiculo(string codigo, string descripcion)
        {
            Descripcion = descripcion;
            if ((codigo == "A") || (codigo == "M") || (codigo == "P")) Codigo = codigo;
            else throw new FormatException("Codigo Incorrecto");

        }

        public TipoVehiculo()
        {
           

        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

    }
}
