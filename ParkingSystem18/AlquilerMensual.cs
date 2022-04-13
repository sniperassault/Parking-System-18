using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class AlquilerMensual:Alquiler
    {
        private string titular;
        private DateTime fechavencimiento;


        public AlquilerMensual(Cochera cochera,string titular,DateTime fechavencimiento) : base(cochera)
        {
            Titular = titular;
            Fechavencimiento = fechavencimiento;
        }

        public AlquilerMensual():base()
        {
            
        }

        public string Titular
        {
            get
            {
                return titular;
            }

            set
            {
                titular = value;
            }
        }

        public DateTime Fechavencimiento
        {
            get
            {
                return fechavencimiento;
            }

            set
            {
                fechavencimiento = value;
            }
        }

        public override double CalcularImporte()
        {   double mes = 30;
            double importe = 1500;
            TimeSpan ts = fechavencimiento - Fecha;
            double dias = ts.TotalDays;
            double total =Convert.ToInt32(dias / mes);
            importe = 1500 * total;
            return importe;

             
        }


    }
}
