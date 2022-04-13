using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParkingSystem18
{
    class XmlManagerUsuario
    {
        private string RutaArchivo4 = @"C:\ParkingSystem18\Usuarios.xml";

        public void GenerarXML(Usuario usuario)
        {
            try
            {
                File.WriteAllText(RutaArchivo4, string.Empty);
                //Preparamos el archivo XML para escritura

                XmlTextWriter writer = new XmlTextWriter(RutaArchivo4, null);

                //Le indicamos que el formato del XML debe ser indentado
                writer.Formatting = Formatting.Indented;

                //Damos comienzo al Documento
                writer.WriteStartDocument();
                writer.WriteStartElement("Usuario");
                writer.WriteElementString("User", Convert.ToString(usuario.User));
                writer.WriteElementString("Password", Convert.ToString(usuario.Password));
                writer.WriteElementString("UltAcceso", Convert.ToString(usuario.UltAcceso));
                writer.WriteElementString("Pregunta", Convert.ToString(usuario.Pregunta));
                writer.WriteElementString("Respuesta", Convert.ToString(usuario.Respuesta));
                writer.WriteEndElement(); //Cerramos la Etiqueta contenedora Alquileres
                writer.WriteEndDocument(); //Cerramos el Documento XML
                writer.Flush(); //Limpiamos la cache
                writer.Close(); //Cerramos el archivo
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerUsuario()
        {
            Usuario usuario = null;


            try
            {
                //Preparamos el archivo XML para lectura
                FileStream archivo = new FileStream(RutaArchivo4, FileMode.Open, FileAccess.Read);

                //Le asignamos un XmlTextReader
                XmlTextReader reader = new XmlTextReader(archivo);

                //Inicializamos un objeto de cada tipo en null

                //Comenzamos el recorrido por el archivo
                while (reader.Read())
                {
                    //Si la etiqueta que estamos leyendo,corresponde a la Apertura de un elemento...
                    if (reader.IsStartElement())
                    {
                        //Comprobamos qué tipo de etiqueta estamos leyendo
                        switch (reader.Name)
                        {
                            case "Usuario":
                                usuario = new Usuario();
                                break;

                            case "User":
                                usuario.User = reader.ReadString();
                                break;

                            case "Password":
                                usuario.Password = reader.ReadString();
                                break;

                            case "UltAcceso":
                                usuario.UltAcceso = Convert.ToDateTime(reader.ReadString());
                                break;

                            case "Pregunta":
                                usuario.Pregunta = reader.ReadString();
                                break;

                            case "Respuesta":
                                usuario.Respuesta = reader.ReadString();
                                break;
                        }
                    }
                }



                reader.Close(); //Cerramos el Reader. IMPORTANTE
                archivo.Close(); //Cerramos el Archivo. IMPORTANTE
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return usuario;
        }

        public bool archivovacio()
        {

            FileStream archivo = new FileStream(RutaArchivo4, FileMode.Open, FileAccess.Read);
            if (archivo.Length == 0)
            {
                archivo.Close();
                return true;
            }
            else
            {
                archivo.Close();
                return false;
            }
        }

    }
}
