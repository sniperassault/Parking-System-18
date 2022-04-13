using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class ColeccionCierres
    {
        List<Cierre> ListaCierres = new List<Cierre>();

        public void Agregar(Cierre cierre)
        { ListaCierres.Add(cierre); }
       
        public void CargarCierres(List<Cierre> lista)
        { ListaCierres.Clear();
            ListaCierres = lista;
        }

        public List<Cierre> MostarTodo()
        { return ListaCierres; }
        public List<Cierre> BuscarXfecha(DateTime fecha)
        {
            try {
                List<Cierre> devolver = new List<Cierre>();
                foreach (Cierre aux in ListaCierres)
                {
                    if (aux.Fecha.Date == fecha.Date) { devolver.Add(aux); }
                }
                if (devolver == null) throw new Exception("No hay registros para esa fecha");
                else return devolver; }
            catch(Exception ex)
            { throw ex; }
        }


    }
}
