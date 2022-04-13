using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
   public class AlquilerHora:Alquiler
    {
       private DateTime desde;
       private DateTime hasta;
       
        public AlquilerHora():base()
        {
           
        }

        public AlquilerHora(Cochera cochera) : base(cochera)
        {
            Desde = DateTime.Now;
            
        }

        public DateTime Desde
        {
            get
            {
                return desde;
            }

            set
            {
                desde = value;
            }
        }

        public DateTime Hasta
        {
            get
            {
                return hasta;
            }

            set
            {
                hasta = value;
            }
        }

        public double ImporteParcial()
        {
            double importe = 0;
            TimeSpan ts = DateTime.Now - desde;
            double horas = ts.TotalHours;
            double horas_enteras = (long)horas;
            double fraccion = horas - horas_enteras;
            if (horas <= 0.666) { horas_enteras = 0.5; fraccion = 0; }
            if (horas > 0.666 && horas < 1) { horas_enteras = 1; fraccion = 0; }
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "A") importe = 80 * horas_enteras;
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "M") importe = 40 * horas_enteras;
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "P") importe = 120 * horas_enteras;
            if (fraccion >= 0.166 && fraccion <= 0.666) importe = importe + (importe / horas_enteras / 2);
            if (fraccion > 0.666) importe = importe + (importe / horas_enteras);
            return importe;
        }

        public override double CalcularImporte()
        { double importe = 0;
            TimeSpan ts = hasta - desde;
            double horas = ts.TotalHours;
            double horas_enteras = (long)horas;
            double fraccion = horas - horas_enteras;
            if (horas <= 0.666) { horas_enteras = 0.5; fraccion = 0; }
            if (horas > 0.666 && horas < 1) { horas_enteras = 1; fraccion = 0; }
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "A") importe = 80 * horas_enteras;
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "M") importe = 40 * horas_enteras;
            if (Cochera.Vehiculo.Tipovehiculo.Codigo == "P") importe = 120 * horas_enteras;
            if (fraccion >= 0.166 && fraccion <= 0.666) importe = importe + (importe / horas_enteras / 2);
            if (fraccion > 0.666) importe = importe + (importe / horas_enteras);
            return importe;
                



        }
    }
}
