using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class Vehiculo
    {
       private string dominio;
       private string marca;
       private string modelo;
       private TipoVehiculo tipovehiculo;

        public Vehiculo(string dominio, string marca,string modelo,TipoVehiculo Vehiculo)
        {
            Dominio = dominio;
            Marca = marca;
            Modelo = modelo;
            Tipovehiculo = Vehiculo;
        }

        public Vehiculo()
        {
            
        }

        public string Dominio
        {
            get
            {
                return dominio;
            }

            set
            {
                dominio = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public TipoVehiculo Tipovehiculo
        {
            get
            {
                return tipovehiculo;
            }

            set
            {
                tipovehiculo = value;
            }
        }
    }
}
