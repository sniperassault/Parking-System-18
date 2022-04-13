using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem18
{
    public partial class FormPrincipal : Form

    {
        ColeccionMovimientos ListaMov;
        ColeccionCierres ListaCierres;
        ColeccionAlquileres ListaAlquileres;
        Usuario usuario;
        XmlManagerMovimientos xmlMovimientos;
        XmlManagerCierres xmlCierres;
        XmlManagerUsuario xmlUsuario;
        XmlManagerAlquileres xmlAlquileres;
        double caja;
        double cajaIn;
        double cajaEg;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {    int i = 0;
                Button aux = null;
                for (i = 1; i < 21; i++)
                {
                    foreach (Control btn in tabAlquileres.Controls)
                    {
                        if (btn.Name == ("btnC" + i)) { aux = (Button)btn; break; }
                    }
                    new ToolTip().SetToolTip(aux, ("Cochera " + (i)));
                }

                xmlAlquileres = new XmlManagerAlquileres();
                xmlUsuario = new XmlManagerUsuario();
                xmlCierres = new XmlManagerCierres();
                xmlMovimientos = new XmlManagerMovimientos();
                ListaAlquileres = new ColeccionAlquileres();
                ListaMov = new ColeccionMovimientos();
                ListaCierres = new ColeccionCierres();
                usuario = new Usuario();
                usuario = xmlUsuario.ObtenerUsuario();
                if (!xmlAlquileres.archivovacio())
                    ListaAlquileres.CargarLista(xmlAlquileres.ObtenerAlquileres());
                if (!xmlMovimientos.archivovacio())
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                if (!xmlCierres.archivovacio())
                    ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                //Cuentas de caja
                caja = ListaMov.IngresosCaja() - ListaMov.EgresosCaja();
                cajaIn = ListaMov.IngresosCaja();
                cajaEg = ListaMov.EgresosCaja();
                lblMovimientosCaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ "+(cajaIn)+"\n\nTotal de egresos:$ "+(cajaEg));
                ///////////
                ActualizarMovimientos(ref dgvMovimientos, ListaMov, 1);
                dgvUsuariosCierres.DataSource = null;
                dgvUsuariosCierres.DataSource = ListaCierres.MostarTodo();
                dgvCierres.DataSource = null;dgvCierres.Rows.Clear();
                CambiarColor();
                lstAlertas.DataSource = ListaAlquileres.Alertas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
     
        public static void ActualizarMovimientos(ref DataGridView dgvMovimientos, ColeccionMovimientos ListaMov, int TipoMovimiento)
        {try
            {
                XmlManagerMovimientos xml = new XmlManagerMovimientos();
                if (!xml.archivovacio())
                {
                    ListaMov.CargarMovimientos(xml.ObtenerMovimientos());
                    List<Movimiento> lista = new List<Movimiento>();
                    dgvMovimientos.DataSource = null;
                    dgvMovimientos.Rows.Clear();
                    if (TipoMovimiento == 1)
                        lista = ListaMov.DevolverMovimientosCaja();
                    if (TipoMovimiento == 2)
                        lista = ListaMov.DevolverIngresos();
                    if (TipoMovimiento == 3)
                        lista = ListaMov.DevolverEgresos();

                    int i = 0;
                    foreach (Movimiento aux in lista)
                    {
                        dgvMovimientos.Rows.Add();
                        dgvMovimientos.Rows[i].Cells[0].Value = aux.Fecha;
                        dgvMovimientos.Rows[i].Cells[1].Value = aux.Concepto;
                        if (aux.EsIngreso == true)
                            dgvMovimientos.Rows[i].Cells[2].Value = aux.Importe;
                        else
                            dgvMovimientos.Rows[i].Cells[3].Value = aux.Importe;
                        dgvMovimientos.Rows[i].Cells[4].Value = aux.Usuario.User;
                        i++;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(6, btnC6);
        }

        private void rbnBuscarIngresos_CheckedChanged(object sender, EventArgs e)
        {
            try {
                if (rbnBuscarTodo.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 1);
                if (rbnBuscarIngresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 2);
                if (rbnBuscarEgresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 3);
            }
            catch (ArgumentOutOfRangeException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }

        private void CambiarColor()
        {
            Button aux = null;
            int i = 1;

            for (i = 1; i < 21; i++)
            {
                foreach (Control btn in tabAlquileres.Controls)
                {
                    if (btn.Name == ("btnC" + i)) { aux = (Button)btn; break; }
                }


                if (ListaAlquileres.Buscar(i) != null && ListaAlquileres.Buscar(i).Cochera.Estado == true)
                {
                  aux.BackColor = Color.Red;
                    if (ListaAlquileres.Buscar(i).Cochera.Vehiculo.Tipovehiculo.Codigo == "A") aux.Image = Properties.Resources.auto;
                    if (ListaAlquileres.Buscar(i).Cochera.Vehiculo.Tipovehiculo.Codigo == "M") aux.Image = Properties.Resources.moto;
                    if (ListaAlquileres.Buscar(i).Cochera.Vehiculo.Tipovehiculo.Codigo == "P") aux.Image = Properties.Resources.pickup;
                }

            }




        }

        private void IniciarFinalizarAlquileres(int numero, Button btn)
        {
            try {
                ListaAlquileres.BorraTodo();
                if(xmlAlquileres.archivovacio()==false)
                ListaAlquileres.CargarLista(xmlAlquileres.ObtenerAlquileres());
                rbnBuscarTodo.Checked = true;
                FormAlquilerInicio forminicio;
                FormAlquilerFinalizar formfin;
                if (ListaAlquileres.Buscar(numero) == null)
                { forminicio = new FormAlquilerInicio(numero, btn,lblMovimientosCaja, caja, dgvMovimientos); forminicio.ShowDialog(); }
                else
                { formfin = new FormAlquilerFinalizar(numero, btn,lblMovimientosCaja, caja, dgvMovimientos); formfin.ShowDialog(); }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            }

        private void btnC1_Click(object sender, EventArgs e)
        {

            IniciarFinalizarAlquileres(1, btnC1);


        }

        private void btnC2_Click(object sender, EventArgs e)
        {

            IniciarFinalizarAlquileres(2, btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(3, btnC3);
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(4, btnC4);
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(5, btnC5);
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(7, btnC7);
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(8, btnC8);
        }

        private void btnC20_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(20, btnC20);
        }

        private void btnC19_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(19, btnC19);
        }

        private void btnC18_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(18, btnC18);
        }

        private void btnC17_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(17, btnC17);
        }

        private void btnC16_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(16, btnC16);
        }

        private void btnC11_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(15, btnC15);
        }

        private void btnC12_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(12, btnC12);
        }

        private void btnC13_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(13, btnC13);
        }

        private void btnC14_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(14, btnC14);
        }

        private void btnC15_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(15, btnC15);
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(10, btnC10);
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            IniciarFinalizarAlquileres(9, btnC9);
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            try {

                if (dgvMovimientos.RowCount > 0)
                {
                    usuario.UltAcceso = DateTime.Now;
                    xmlUsuario.GenerarXML(usuario);
                    Cierre cierre = new Cierre(DateTime.Now, usuario);
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                    ListaMov.ModificarMovimientos(cierre);
                    xmlCierres.GenerarXML(cierre);
                    File.WriteAllText(@"C:\ParkingSystem18\Movimientos.xml", "");
                    foreach (Movimiento aux in ListaMov.MostarTodo())
                    {   
                        xmlMovimientos.GenerarXML(aux);
                    }
                    lblMovimientosCaja.Text = ("Total en caja:$ 0\n\nTotal de ingresos:$ 0\n\nTotal de egresos:$ 0");
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                    ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                    FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 1);
                    dgvUsuariosCierres.DataSource = null;
                    ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                    dgvUsuariosCierres.DataSource = ListaCierres.MostarTodo();
                    dgvCierres.DataSource = null; dgvCierres.Rows.Clear();
                    MessageBox.Show("Caja Cerrada");

                    
                }
                else MessageBox.Show("No se han registrado movimientos. No se pude cerrar la caja");
               


            }
            catch (ArgumentOutOfRangeException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void btnRegistarEgreso_Click(object sender, EventArgs e)
        {
            try {
                FormEgresos form = new FormEgresos(lblMovimientosCaja, caja, dgvMovimientos);
                rbnBuscarTodo.Checked = true;
                form.ShowDialog(); }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void chkBuscarFechas_CheckedChanged(object sender, EventArgs e)
        {
            try {if(xmlMovimientos.archivovacio()==false)
                ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                if (xmlCierres.archivovacio() == false)
                    ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                dgvUsuariosCierres.DataSource = null;
                dgvCierres.DataSource = null;
                dgvCierres.Rows.Clear();
                if (chkBuscarFechas.Checked == true) { dtpBuscarMovimiento.Enabled = true; bntRealizarBusqueda.Enabled = true; }
                else
                {
                    bntRealizarBusqueda.Enabled = false; dtpBuscarMovimiento.Enabled = false; dgvUsuariosCierres.DataSource = null;
                    if (xmlCierres.archivovacio() == false)
                    {
                        ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                        dgvUsuariosCierres.DataSource = ListaCierres.MostarTodo();
                    }
                }
            }
            catch(Exception ex)
                { MessageBox.Show(ex.Message); }
            }

        private void bntRealizarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (xmlMovimientos.archivovacio() == false)
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                if (xmlCierres.archivovacio() == false)
                    ListaCierres.CargarCierres(xmlCierres.ObtenerCierres());
                DateTime fecha = Convert.ToDateTime(dtpBuscarMovimiento.Value);
                dgvCierres.DataSource = null; dgvCierres.Rows.Clear();
                dgvUsuariosCierres.DataSource = null;
                dgvUsuariosCierres.DataSource = ListaCierres.BuscarXfecha(fecha);
                //Caja cierres
                double caja = ListaMov.TotalCierre(fecha, 2) - ListaMov.TotalCierre(fecha, 3);
                double cajaIn = ListaMov.TotalCierre(fecha, 2);
                double cajaEg = ListaMov.TotalCierre(fecha, 3);
                lblCierreCaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
            }
            ///////
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }


        }

        private void rbnBuscarTodo_CheckedChanged(object sender, EventArgs e)
        {
            try {
                if (rbnBuscarTodo.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 1);
                if (rbnBuscarIngresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 2);
                if (rbnBuscarEgresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 3); }
            catch (ArgumentOutOfRangeException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void rbnBuscarEgresos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbnBuscarTodo.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 1);
                if (rbnBuscarIngresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 2);
                if (rbnBuscarEgresos.Checked == true) FormPrincipal.ActualizarMovimientos(ref dgvMovimientos, ListaMov, 3); }
            catch (ArgumentOutOfRangeException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void ActualizarCierres()
        {try
            {
                if (xmlMovimientos.archivovacio() == false)
                    ListaMov.CargarMovimientos(xmlMovimientos.ObtenerMovimientos());
                List<Movimiento> lista = new List<Movimiento>();
                DateTime date = DateTime.Now;
                var filaSeleccionada = dgvUsuariosCierres.CurrentRow;

                if (filaSeleccionada != null) //¿Existe una referencia?
                {
                    
                    date =Convert.ToDateTime(filaSeleccionada.Cells[0].Value);
                    dgvCierres.DataSource = null;
                    dgvCierres.Rows.Clear();
                    if (rbtCierresMostrarTodo.Checked == true)
                        lista = ListaMov.BuscarCierres(date, 1);
                    if (rbtCierresMostrarIngresos.Checked == true)
                        lista = ListaMov.BuscarCierres(date, 2);
                    if (rbtCierresMostrarEgresos.Checked == true)
                        lista = ListaMov.BuscarCierres(date, 3);

                    int i = 0;
                    foreach (Movimiento aux in lista)
                    {
                        dgvCierres.Rows.Add();
                        dgvCierres.Rows[i].Cells[0].Value = aux.Fecha;
                        dgvCierres.Rows[i].Cells[1].Value = aux.Concepto;
                        if (aux.EsIngreso == true)
                            dgvCierres.Rows[i].Cells[2].Value = aux.Importe;
                        else
                            dgvCierres.Rows[i].Cells[3].Value = aux.Importe;
                        dgvCierres.Rows[i].Cells[4].Value = aux.Usuario.User;
                        i++;
                    }

                    //Caja cierres
                    double caja = ListaMov.TotalCierre(date, 2) - ListaMov.TotalCierre(date, 3);
                    double cajaIn = ListaMov.TotalCierre(date, 2);
                    double cajaEg = ListaMov.TotalCierre(date, 3);
                    lblCierreCaja.Text = ("Total en caja:$ " + (caja) + "\n\nTotal de ingresos:$ " + (cajaIn) + "\n\nTotal de egresos:$ " + (cajaEg));
                    ///////
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void dgvUsuariosCierres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ActualizarCierres();
        }

        private void dgvCierres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelCierresBuscar_Click(object sender, EventArgs e)
        {

        }

        private void rbtCierresMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCierres();
        }

        private void rbtCierresMostrarIngresos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCierres();
        }

        private void rbtCierresMostrarEgresos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCierres();
        }

        private void tabMovimientos_Click(object sender, EventArgs e)
        {

        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstAlertas_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {
                lstAlertas.DataSource = null;
                if (xmlAlquileres.archivovacio() == false)
                    ListaAlquileres.CargarLista(xmlAlquileres.ObtenerAlquileres());
                lstAlertas.DataSource = ListaAlquileres.Alertas();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnOpcionesCambiarUsuario_Click(object sender, EventArgs e)
        {try
            {
                Usuario usuario;
                if (txtOpcionesUsuario.Text != "" && txtOpcionesContraseña.Text == txtOpcionesConfirmar.Text && txtOpcionesContraseña.Text != "")
                {
                    usuario = new Usuario(txtOpcionesUsuario.Text, txtOpcionesContraseña.Text, xmlUsuario.ObtenerUsuario().Pregunta, xmlUsuario.ObtenerUsuario().Respuesta);
                    xmlUsuario.GenerarXML(usuario);
                    txtOpcionesConfirmar.Clear(); txtOpcionesContraseña.Clear(); txtOpcionesUsuario.Clear();
                    MessageBox.Show("Usuario y contraseña modificados correctamente!!!\n");
                    MessageBox.Show("Se cerrara la aplicacion para efectuar los cambios");
                    Application.Exit();
                }
                else { MessageBox.Show("DATOS INVALIDOS.VUELVA A ESCRIBIR LOS CAMPOS"); txtOpcionesConfirmar.Clear(); txtOpcionesContraseña.Clear(); txtOpcionesUsuario.Clear(); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnOpcionesCambiarPregunta_Click(object sender, EventArgs e)
        {try
            {
                Usuario usuario;
                if (txtOpcionesPregunta.Text != "" && txtOpcionesRespuesta.Text != "")
                {
                    usuario = new Usuario(xmlUsuario.ObtenerUsuario().User, xmlUsuario.ObtenerUsuario().Password, txtOpcionesPregunta.Text, txtOpcionesRespuesta.Text);
                    xmlUsuario.GenerarXML(usuario);
                    txtOpcionesRespuesta.Clear(); txtOpcionesPregunta.Clear();
                    MessageBox.Show("Pregunta de seguridad cambiada!!!");
                }
                else { MessageBox.Show("DATOS INVALIDOS.VUELVA A ESCRIBIR LOS CAMPOS"); txtOpcionesRespuesta.Clear(); txtOpcionesPregunta.Clear(); }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void lblOpcionesRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
    }
