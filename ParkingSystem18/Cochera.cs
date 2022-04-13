using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class Cochera
    {
       private int id;
       private bool estado;
       private Vehiculo vehiculo;

        public Cochera(bool estado,Vehiculo vehiculo,int id)
        {   Estado = estado;
            Vehiculo = vehiculo;
            Id = id;
            
        }

        public Cochera()
        {
            
        }


        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return vehiculo;
            }

            set
            {
                vehiculo = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    } 
}

