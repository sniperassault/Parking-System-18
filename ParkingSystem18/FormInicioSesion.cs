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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            XmlManagerUsuario xml = new XmlManagerUsuario();
            usuario=xml.ObtenerUsuario();
            try {
                if (txtIniciarSesionUser.Text == usuario.User && txtIniciarSesionPassword.Text == usuario.Password)
                {
                    txtIniciarSesionUser.Clear();
                    txtIniciarSesionPassword.Clear();
                    FormPrincipal formulario1 = new FormPrincipal();
                    formulario1.ShowDialog();
                    
                }
                else MessageBox.Show("Datos Invalidos");
                txtIniciarSesionUser.Clear();
                txtIniciarSesionPassword.Clear();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
           

                
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void lblRestablecerContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   try
            {
                FormRestablecerContraseña form = new FormRestablecerContraseña();
                form.ShowDialog();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
           
        }
    }
}
