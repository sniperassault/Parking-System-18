using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem18
{
    public partial class FormAlquilerFinalizar : Form
    {
        XmlManagerMovimientos xmlMovimientos;
        XmlManagerAlquileres xmlAlquileres;
        XmlManagerUsuario xmlUsuarios;
        Usuario usuario;
        ColeccionAlquileres ListaAlquileres;
        ColeccionMovimientos ListaMov;
        int numero;
        Button btn;
        Label btncaja;
        double caja;
        DataGridView dgv;


        public FormAlquilerFinalizar(int numero,Button btn, Label btncaja, double caja,DataGridView dgv)
        {
            InitializeComponent();
            this.btncaja = btncaja;
            this.caja = caja;
            this.btn = btn;
            this.numero = numero;
            this.dgv = dgv;
           
        }

        private void FormAlquilerFinalizar_Load(object sender, EventArgs e)
        {
            try {
                xmlAlquileres = new XmlManagerAlquileres();
                xmlMovimientos = new XmlManagerMovimientos();
                xmlUsuarios = new XmlManagerUsuario();
                ListaAlquileres = new ColeccionAlquileres();
                ListaMov = new ColeccionMovimientos();
                ListaAlquileres.CargarLista(xmlAlquileres.ObtenerAlquileres());
                if (xmlMovimientos.archivovacio() == false)
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                usuario = xmlUsuarios.ObtenerUsuario();
                AlquilerHora ah;
                AlquilerMensual am;
                lblFinalizarAlquilerFecha.Text = Convert.ToString(ListaAlquileres.Buscar(numero).Fecha);
                if (ListaAlquileres.Buscar(numero).GetType() == typeof(AlquilerMensual))
                {
                    am = (AlquilerMensual)ListaAlquileres.Buscar(numero);
                    lblImporteParcial.Text = "Vencimiento: "+(am.Fechavencimiento);
                    btnRenovarAlquiler.Enabled = true; numAlquilerMensualRenovacion.Enabled = true; }
                else
                {
                    ah = (AlquilerHora)ListaAlquileres.Buscar(numero);
                    lblImporteParcialMostrar.Text = "$ " + (Convert.ToString(ah.ImporteParcial()));
                    btnRenovarAlquiler.Enabled = false; numAlquilerMensualRenovacion.Enabled = false; }

            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}



        }

        private void btnRenovarAlquiler_Click(object sender, EventArgs e)
        {
            try {
                int num = numero;
                AlquilerMensual am = (AlquilerMensual)ListaAlquileres.Buscar(num);
                ListaAlquileres.RenovarAlquiler(am, Convert.ToInt32(numAlquilerMensualRenovacion.Value));
                Movimiento mov;
                double importe = 0;
                importe = 1500 * Convert.ToInt32(numAlquilerMensualRenovacion.Value);
                mov = new Movimiento("Renovacion Alquiler", importe, true, usuario);
                ListaMov.Agregar(mov);
                //cuentas caja
                double cajaIn = ListaMov.IngresosCaja();
                double cajaEg = ListaMov.EgresosCaja();
                caja = ListaMov.IngresosCaja() - ListaMov.EgresosCaja();
                btncaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
                /////
                MessageBox.Show("Alquler actualizado. Total a cobrar: $" + (importe));
                xmlMovimientos.GenerarXML(mov);
                xmlAlquileres.CargarTodo(ListaAlquileres.MostrarTodo());                
                FormPrincipal.ActualizarMovimientos(ref dgv, ListaMov, 1);
                this.Close(); }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnFinalizarAlquiler_Click(object sender, EventArgs e)
        {
            try {
                Movimiento mov;
                double importe = 0;
                int num = numero;
                Alquiler alquiler = ListaAlquileres.Buscar(num);
                if (alquiler.GetType() == typeof(AlquilerHora))
                { AlquilerHora ah = (AlquilerHora)alquiler;
                    ah.Hasta = DateTime.Now;
                    importe = ah.CalcularImporte();
                    MessageBox.Show("Total a cobrar: $" + (importe));
                    mov = new Movimiento("Alquiler Hora", importe, true, usuario);
                    btn.Image = null;
                    btn.BackColor = Color.LawnGreen;
                    ListaAlquileres.Borrar(num);//borro alquiler de la lista
                    xmlAlquileres.CargarTodo(ListaAlquileres.MostrarTodo());//actualizo xml
                    ListaMov.Agregar(mov);
                    xmlMovimientos.GenerarXML(mov);
                    //cuentas caja
                    double cajaIn = ListaMov.IngresosCaja();
                    double cajaEg = ListaMov.EgresosCaja();
                    caja = ListaMov.IngresosCaja() - ListaMov.EgresosCaja();
                    btncaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
                    /////
                    FormPrincipal.ActualizarMovimientos(ref dgv, ListaMov, 1);
                    this.Close();

                }
                else
                {
                    ListaAlquileres.Borrar(num);
                    xmlAlquileres.CargarTodo(ListaAlquileres.MostrarTodo());
                    btn.Image = null;
                    btn.BackColor = Color.LawnGreen;
                    this.Close();

                }


            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            }

        private void lblFinalizarAlquilerFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            try {
                Alquiler alquiler = ListaAlquileres.Buscar(numero);
                AlquilerMensual am;
                AlquilerHora ah;
                if (alquiler.GetType() == typeof(AlquilerHora))
                {
                    ah = (AlquilerHora)alquiler;
                    MessageBox.Show("Dominio: " + (ah.Cochera.Vehiculo.Dominio) + "\nMarca: " + (ah.Cochera.Vehiculo.Marca) + "\nModelo: " + (ah.Cochera.Vehiculo.Modelo));
                }
                if (alquiler.GetType() == typeof(AlquilerMensual))
                {
                    am = (AlquilerMensual)alquiler;
                    MessageBox.Show("Dominio: " + (am.Cochera.Vehiculo.Dominio) + "\nMarca: " + (am.Cochera.Vehiculo.Marca) + "\nModelo: " + (am.Cochera.Vehiculo.Modelo) + "\nTitular: " + (am.Titular));
                } }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
 
        }
    }
}
