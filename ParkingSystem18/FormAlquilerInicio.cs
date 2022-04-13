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
    public partial class FormAlquilerInicio : Form
    {
        
        XmlManagerAlquileres xmlAlquileres;
        XmlManagerMovimientos xmlMovimientos;
        XmlManagerUsuario xmlUsuarios;
       ColeccionAlquileres ListaAlquileres;
       ColeccionMovimientos ListaMov;
       Usuario usuario;
       private int numero;
        Button btn;
        Label btncaja;
        double caja;
        DataGridView dgv;
        public FormAlquilerInicio(int numero,Button btn,Label btncaja,double caja,DataGridView dgv)
        {
            this.btncaja = btncaja;
            this.caja = caja;
            this.numero = numero;
            this.btn = btn;
            InitializeComponent();
            this.dgv = dgv;
        }

        private void lblTipoAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void txtAlquilerMensualTitular_TextChanged(object sender, EventArgs e)
        {
            if (rbtAlquilerMensual.Checked) txtAlquilerMensualTitular.Enabled = true;
            else txtAlquilerMensualTitular.Enabled =false;
    
        }

        private void numAlquilerMensualCantidadMeses_ValueChanged(object sender, EventArgs e)
        {
            if (rbtAlquilerMensual.Checked) numAlquilerMensualCantidadMeses.Enabled = true;
            else txtAlquilerMensualTitular.Enabled = false;
        }

        private void btnComenzarAlquilerHora_Click(object sender, EventArgs e)
        {
            try {
                Movimiento mov;
                Cochera c;
                Vehiculo v;
                TipoVehiculo tv;
                AlquilerHora ah;
                AlquilerMensual am;
                if (xmlMovimientos.archivovacio() == false)
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                usuario = xmlUsuarios.ObtenerUsuario();

                if (ListaAlquileres.VerificarPatente(txtAlquilerDominio.Text) == true) MessageBox.Show("Ya existe un vehiculo con esa patente");
                else
                {
                    if (((rbtAlquilerMensual.Checked == true) && ((string.IsNullOrEmpty(txtAlquilerMensualTitular.Text)) || (string.IsNullOrEmpty(txtAlquilerDominio.Text)) || (string.IsNullOrEmpty(txtAlquilerMarca.Text)) || (string.IsNullOrEmpty(txtAlquilerModelo.Text))))
                          || ((rbtAlquilerHora.Checked == true) && ((string.IsNullOrEmpty(txtAlquilerDominio.Text)) || (string.IsNullOrEmpty(txtAlquilerMarca.Text)) || (string.IsNullOrEmpty(txtAlquilerModelo.Text)))))
                        MessageBox.Show("Faltan completar datos");
                    else {
                        string codigo = "A";
                        string descripcion = "";
                        if (rbnAuto.Checked == true) { codigo = "A"; descripcion = "Auto"; btn.Image = Properties.Resources.auto;  }
                        if (rbnMoto.Checked == true) { codigo = "M"; descripcion = "Moto"; btn.Image = Properties.Resources.moto; }
                        if (rbnPickup.Checked == true) { codigo = "P"; descripcion = "Pickup"; btn.Image = Properties.Resources.pickup; }
                        tv = new TipoVehiculo(codigo, descripcion);
                        v = new Vehiculo(txtAlquilerDominio.Text, txtAlquilerMarca.Text, txtAlquilerModelo.Text, tv);
                        c = new Cochera(true, v, numero);
                   
                    
                    
                            if (rbtAlquilerHora.Checked == true)
                            {

                                ah = new AlquilerHora(c);
                                ListaAlquileres.Agregar(ah);
                                btn.BackColor = Color.Red;
                                xmlAlquileres.GenerarXML(ah);
                                this.Close();

                            }
                            else
                            {

                                am = new AlquilerMensual(c, txtAlquilerMensualTitular.Text, DateTime.Now.AddMonths(Convert.ToInt32(numAlquilerMensualCantidadMeses.Value)));
                                ListaAlquileres.Agregar(am);
                                double importe = am.CalcularImporte();
                                MessageBox.Show("Total a cobrar: $" + (importe));
                                mov = new Movimiento("Alquiler Mensual", importe, true, usuario);
                                ListaMov.Agregar(mov);
                                //cuentas caja
                                double cajaIn = ListaMov.IngresosCaja();
                                double cajaEg = ListaMov.EgresosCaja();
                                caja = ListaMov.IngresosCaja() - ListaMov.EgresosCaja();
                                btncaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
                                /////
                                btn.BackColor = Color.Red;
                                xmlMovimientos.GenerarXML(mov);
                                xmlAlquileres.GenerarXML(am);
                                FormPrincipal.ActualizarMovimientos(ref dgv, ListaMov, 1);
                                this.Close();
                            }

                        }
                    }



                } 
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            }

        private void FormAlquilerInicio_Load(object sender, EventArgs e)
        {
            try {
                xmlAlquileres = new XmlManagerAlquileres();
                xmlMovimientos = new XmlManagerMovimientos();
                xmlUsuarios = new XmlManagerUsuario();
                ListaAlquileres = new ColeccionAlquileres();
                ListaMov = new ColeccionMovimientos();
                usuario = new Usuario();
                if (xmlAlquileres.archivovacio() == false)
                    ListaAlquileres.CargarLista(xmlAlquileres.ObtenerAlquileres()); }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

           
        }

        private void rbtAlquilerHora_CheckedChanged(object sender, EventArgs e)
        {if (rbtAlquilerHora.Checked == false)
            { txtAlquilerMensualTitular.Enabled = true;
                numAlquilerMensualCantidadMeses.Enabled = true; }
            else
            {
                txtAlquilerMensualTitular.Enabled =false;
                numAlquilerMensualCantidadMeses.Enabled = false;
            }
        }

        private void rbtAlquilerMensual_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (rbtAlquilerMensual.Checked == false)
                {
                    txtAlquilerMensualTitular.Enabled = false;
                    numAlquilerMensualCantidadMeses.Enabled = false;
                }
                else
                {
                    txtAlquilerMensualTitular.Enabled = true;
                    numAlquilerMensualCantidadMeses.Enabled = true;
                }
            }
        }
    }
}
