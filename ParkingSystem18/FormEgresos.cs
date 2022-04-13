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
    public partial class FormEgresos : Form
    {
       
        Usuario usuario;
        XmlManagerMovimientos xml;
        XmlManagerUsuario xmlUser;
        Label btncaja;
        double caja;
        DataGridView dgv;
        public FormEgresos(Label btncaja,double caja,DataGridView dgv)
        {
            this.btncaja = btncaja;
            this.caja = caja;
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnEgresoCargar_Click(object sender, EventArgs e)
        {
            try
            { 
                usuario = xmlUser.ObtenerUsuario();
                if (txtEgresosConcepto.Text == "") MessageBox.Show("Ingrese un concepto de egreso");
                else
                {
                    Movimiento mov = new Movimiento(txtEgresosConcepto.Text, Convert.ToDouble(mtbEgresoImporte.Value), false, usuario);
                    xml.GenerarXML(mov);
                    MessageBox.Show("Egreso guardado");
                    //cuentas caja
                    ColeccionMovimientos ListaMov = new ColeccionMovimientos();
                    ListaMov.CargarMovimientos(xml.ObtenerMovimientos());
                    double cajaIn = ListaMov.IngresosCaja();
                    double cajaEg = ListaMov.EgresosCaja();
                    caja = ListaMov.IngresosCaja() - ListaMov.EgresosCaja();
                    btncaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
                    /////
                    FormPrincipal.ActualizarMovimientos(ref dgv, ListaMov, 1);
                    this.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void FormEgresos_Load(object sender, EventArgs e)
        {
            xml = new XmlManagerMovimientos();
            xmlUser = new XmlManagerUsuario();
            
        }
    }
}
