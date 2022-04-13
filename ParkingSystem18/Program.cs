 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingSystem18
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
         string ruta = @"C:\ParkingSystem18\Usuarios.xml";
         string RutaArchivo2 = @"C:\ParkingSystem18\Cierres.xml";
         string RutaArchivo3 = @"C:\ParkingSystem18\Movimientos.xml";
         string RutaArchivo4 = @"C:\ParkingSystem18\Alquileres.xml";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(ruta) == false)
            {
                if (Directory.Exists(@"C:\ParkingSystem18") == false)
                { DirectoryInfo di = Directory.CreateDirectory(@"C:\ParkingSystem18"); }
                StreamWriter file = File.AppendText(@"C:\ParkingSystem18\Usuarios.xml");
                file.Close();
                XmlManagerUsuario xml = new XmlManagerUsuario();
                if (xml.archivovacio())
                {
                    Usuario user = new Usuario("Admin", "1234", DateTime.Now);
                    user.Pregunta = "Nombre de la aplicacion";
                    user.Respuesta = "Parking System 18";
                    xml.GenerarXML(user);
                }
            }
            if (File.Exists(RutaArchivo2) == false)
            {
                if (Directory.Exists(@"C:\ParkingSystem18") == false)
                { DirectoryInfo di = Directory.CreateDirectory(@"C:\ParkingSystem18"); }
                StreamWriter file = File.AppendText(RutaArchivo2);
                file.Close();
               
            }
            if (File.Exists(RutaArchivo3) == false)
            {
                if (Directory.Exists(@"C:\ParkingSystem18") == false)
                { DirectoryInfo di = Directory.CreateDirectory(@"C:\ParkingSystem18"); }
                StreamWriter file = File.AppendText(RutaArchivo3);
                file.Close();

            }
            if (File.Exists(RutaArchivo4) == false)
            {
                if (Directory.Exists(@"C:\ParkingSystem18") == false)
                { DirectoryInfo di = Directory.CreateDirectory(@"C:\ParkingSystem18"); }
                StreamWriter file = File.AppendText(RutaArchivo4);
                file.Close();

            }

            Application.Run(new FormInicioSesion());

        }

      
    }
}
