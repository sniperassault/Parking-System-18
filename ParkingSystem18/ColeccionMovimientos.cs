using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem18
{
    public class ColeccionMovimientos
    {
        List<Movimiento> ListaMovimientos = new List<Movimiento>();
        
        public void Agregar(Movimiento movimiento)
        { ListaMovimientos.Add(movimiento); }

        public List<Movimiento> MostarTodo()
        {  return ListaMovimientos; }

       public void CargarMovimientos(List<Movimiento> lista)
        { ListaMovimientos.Clear();
          ListaMovimientos = lista;  
        }

        public bool ModificarMovimientos(Cierre cierre)
        {
            bool encontro = false;
            foreach (Movimiento mov in ListaMovimientos)
            {
                if (mov.Cierre==null)
                {
                    mov.Cierre = cierre;
                    encontro = true;
                }
            }
            return encontro;
        }

        public List<Movimiento> DevolverIngresos()
        {
            List<Movimiento> Ingresos = new List<Movimiento>();

            foreach (Movimiento mov in ListaMovimientos)
            {
                if (mov.EsIngreso && (mov.Cierre == null))
                {
                    Ingresos.Add(mov);
                }
            }

            return Ingresos;
        }


        public List<Movimiento> DevolverEgresos()
        {
            List<Movimiento> Egresos = new List<Movimiento>();

            foreach (Movimiento mov in ListaMovimientos)
            {
                if (!mov.EsIngreso && (mov.Cierre == null))
                {
                    Egresos.Add(mov);
                }
            }

            return Egresos;
        }

        public List<Movimiento> DevolverMovimientosCaja()
        {
            List<Movimiento> lista = new List<Movimiento>();
            lista.AddRange(DevolverIngresos());
            lista.AddRange(DevolverEgresos());
            return lista;
                
                
        }

        public double IngresosCaja()
        {
            double CajaIngresos = 0;

            foreach (Movimiento mov in ListaMovimientos)
            {
                if (mov.EsIngreso && (mov.Cierre == null))
                {
                    CajaIngresos += mov.Importe;
                }
            }

            return CajaIngresos;
        }

        public double EgresosCaja()
        {
            double CajaEgresos = 0;

            foreach (Movimiento mov in ListaMovimientos)
            {
                if (!mov.EsIngreso && (mov.Cierre ==null))
                {
                    CajaEgresos += mov.Importe;
                }
            }

            return CajaEgresos;
        }

        public List<Movimiento> DevovlerCierre(DateTime fecha)
        {
            List<Movimiento> Cierres = new List<Movimiento>();

            foreach (Movimiento mov in ListaMovimientos)
            {
                if (fecha == mov.Cierre.Fecha)
                {
                    Cierres.Add(mov);
                }
            }

            return Cierres;
        }

        public List<Movimiento> BuscarCierres(DateTime Fecha,int tipo)
        {
            try
            {
                List<Movimiento> lista = new List<Movimiento>();
                switch (tipo)
                {
                    case 1:


                        foreach (Movimiento aux in ListaMovimientos)
                        { if (aux.Cierre != null && Fecha == aux.Cierre.Fecha) { lista.Add(aux); } }
                        break;

                    case 2:

                        foreach (Movimiento aux in ListaMovimientos)
                        { if (aux.Cierre != null && Fecha == aux.Cierre.Fecha && aux.EsIngreso == true) { lista.Add(aux); } }
                        break;

                    case 3:

                        foreach (Movimiento aux in ListaMovimientos)
                        { if (aux.Cierre != null && Fecha == aux.Cierre.Fecha && aux.EsIngreso == false) { lista.Add(aux); } }
                        break;

                    default:
                        throw new IndexOutOfRangeException();
                }
                return lista;
            }
            catch(IndexOutOfRangeException ex)
            { throw ex; }
            catch(Exception ex)
            { throw ex; }
            
            }

        public double TotalCierre(DateTime fecha,int tipo)
        {
            List<Movimiento> lista = new List<Movimiento>();
            lista = BuscarCierres(fecha, tipo);
            double caja = 0;
            foreach(Movimiento aux in lista)
            { caja = caja + aux.Importe; }
            return caja;
                
                
         }

    }
}
