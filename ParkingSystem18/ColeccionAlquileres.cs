using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
   public class ColeccionAlquileres
    {
      private  List<Alquiler> ListaAlquileres = new List<Alquiler>();

        public bool VerificarPatente(string patente)
        {
            bool encontro = false;
            foreach (Alquiler aux in ListaAlquileres)
            { if (patente == aux.Cochera.Vehiculo.Dominio) { encontro = true; break; } }

            return encontro;       
        
        }

        public void Agregar(Alquiler alquiler)
        { ListaAlquileres.Add(alquiler); }

        public Alquiler Buscar(int numero)
        {
            Alquiler devolver = null;
            foreach (Alquiler aux in ListaAlquileres)
            {
                if (aux.Cochera.Id == numero) { devolver = aux; break; }

            }

                return devolver;
        }

        public void CargarLista(List<Alquiler> lista)
        {
            ListaAlquileres.Clear();
            ListaAlquileres = lista;
        }

        public List<Alquiler> MostrarTodo()
        { return ListaAlquileres; }
        public void Borrar(int numero)
        {
            
                Alquiler devolver = null;
                foreach (Alquiler aux in ListaAlquileres)
                {
                    if (aux.Cochera.Id == numero) { devolver = aux; break; }
                }
                
                    ListaAlquileres.Remove(devolver);
                   
        }

        public void BorraTodo()
        {
            ListaAlquileres.Clear();
        }



        public void RenovarAlquiler(AlquilerMensual am,int meses)
        { foreach (AlquilerMensual aux in ListaAlquileres)
            { if (am.Cochera.Vehiculo.Dominio == aux.Cochera.Vehiculo.Dominio)
                { aux.Fechavencimiento = aux.Fechavencimiento.AddMonths(meses); break; }
            
            }     
                    
        }

        public List<string> Alertas()
        { List<string> devolver = new List<string>();
            string texto = "";
            int dias = 0;
            TimeSpan ts;
            AlquilerMensual am = new AlquilerMensual();
            foreach(Alquiler aux in ListaAlquileres)
            {   if (aux.GetType() == typeof(AlquilerMensual))
                {
                    am = (AlquilerMensual)aux;
                    texto = "";
                    ts = am.Fechavencimiento - DateTime.Now;
                    dias = Convert.ToInt32(ts.TotalDays);
                    if (dias < 8 && dias >= 1)
                        texto = "EN " + (dias) + " DIAS VENCE EL ALQUILER DE LA COCHERA " + (am.Cochera.Id);
                    if (dias <= 0) texto = "ALQUILER DE LA COCHERA " + (am.Cochera.Id) + " VENCIDO.RENUEVE EL ALQUILER O DESOCUPE LA COCHERA";
                    if (texto != "") devolver.Add(texto);
                }

            }
            return devolver;
                    
        }
       

    }
}
