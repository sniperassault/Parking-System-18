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
    public partial class FormRestablecerContraseña : Form
    {   XmlManagerUsuario xml=new XmlManagerUsuario();
        Usuario usuario = new Usuario();
        public FormRestablecerContraseña()
        {
            InitializeComponent();
        }

        private void FormRestablecerContraseña_Load(object sender, EventArgs e)
        {
            try
            {
                usuario = xml.ObtenerUsuario();
                txtPregunta.Text = usuario.Pregunta;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRespuesta.Text == usuario.Respuesta)
                {
                    MessageBox.Show("Su usuario es: " + (usuario.User) + "\n\nSu contraseña es: " + (usuario.Password));
                    this.Close();
                }
                else MessageBox.Show("Respuesta incorrecta");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
