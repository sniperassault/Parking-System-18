using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ParkingSystem18
{
    class XmlManagerCierres
    {
        private string RutaArchivo2 = @"C:\ParkingSystem18\Cierres.xml";


        public bool archivovacio()
        {

            FileStream archivo = new FileStream(RutaArchivo2, FileMode.Open, FileAccess.Read);
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
        public void GenerarXML(Cierre cierre)
        {
            try
            {
                if (archivovacio())
                {
                    //Preparamos el archivo XML para escritura
                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo2, null);

                    //Le indicamos que el formato del XML debe ser indentado
                    writer.Formatting = Formatting.Indented;

                    //Damos comienzo al Documento
                    writer.WriteStartDocument();

                    //Ceramos una Etiqueta de apertura para Alumnos (Contenedor principal)
                    writer.WriteStartElement("Cierres");

                    //Recorremos la lista de Alquileres
                    
                        //Abrimos una Etiqueta Alquiler
                        writer.WriteStartElement("Cierre");

                        //Creamos una Etiqueta por cada Propiedad del Alquiler
                        writer.WriteElementString("Fecha", Convert.ToString(cierre.Fecha));


                        //Para la cochera, creamos una Etiqueta pero dentra de ella creamos otras Etiquetas para sus Propiedades
                        writer.WriteStartElement("Usuario");
                        writer.WriteElementString("User", cierre.Usuario.User);
                        writer.WriteElementString("Password", cierre.Usuario.Password);
                        writer.WriteElementString("UltAcceso", Convert.ToString(cierre.Usuario.UltAcceso));
                        writer.WriteEndElement();

                        //Cerramos la Etiqueta Cierre
                        writer.WriteEndElement();

                    writer.WriteEndElement(); //Cerramos la Etiqueta contenedora Alquileres
                    writer.WriteEndDocument(); //Cerramos el Documento XML
                    writer.Flush(); //Limpiamos la cache
                    writer.Close(); //Cerramos el archivo
                }
                else
                {
                    XDocument xDocument = XDocument.Load(RutaArchivo2);
                    XElement root = xDocument.Element("Cierres");
                    IEnumerable<XElement> rows = root.Descendants("Cierre");
                    XElement firstRow = rows.First();
                    firstRow.AddBeforeSelf(
                       new XElement("Cierre",
                       new XElement("Fecha", Convert.ToString(cierre.Fecha)),
                       new XElement("Usuario",
                            new XElement("User", cierre.Usuario.User),
                            new XElement("Password",cierre.Usuario.Password),
                            new XElement("UltAcceso", Convert.ToString(cierre.Usuario.UltAcceso)))));
                    xDocument.Save(RutaArchivo2);
                }
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cierre> ObtenerCierres()
        {
            List<Cierre> cierres = new List<Cierre>();

            try
            {
                //Preparamos el archivo XML para lectura
                FileStream archivo = new FileStream(RutaArchivo2, FileMode.Open, FileAccess.Read);

                //Le asignamos un XmlTextReader
                XmlTextReader reader = new XmlTextReader(archivo);

                //Inicializamos un objeto de cada tipo en null
                Cierre cierre = null;
                Usuario usuario = null;

                //Comenzamos el recorrido por el archivo
                while (reader.Read())
                {
                    //Si la etiqueta que estamos leyendo,corresponde a la Apertura de un elemento...
                    if (reader.IsStartElement())
                    {
                        //Comprobamos qué tipo de etiqueta estamos leyendo
                        switch (reader.Name)
                        {
                            case "Cierres": //Etiqueta principal, no hace falta hacer nada
                                break;

                            case "Cierre": //cierre, creamos un nuevo cierre
                                cierre = new Cierre();
                                break;

                            case "Usuario":
                                cierre.Usuario = new Usuario(); //Instanciamos un Objeto usuario y lo asignamos al cierre
                                break;

                            case "Fecha":
                                if (reader.Read())
                                    cierre.Fecha = Convert.ToDateTime(reader.ReadString()); //Asignamos fecha al cierre
                                break;

                            case "User": //Asignamos User a al Usuario del Cierre
                                if (reader.Read())
                                    cierre.Usuario.User = reader.ReadString();
                                break;

                            case "Password": //Asignamos password al usuario del Cierre
                                if (reader.Read())
                                    cierre.Usuario.Password = reader.ReadString();
                                break;

                            case "UltAcceso": //Asignamos fecha al usuario del Cierre
                                if (reader.Read())
                                    cierre.Usuario.UltAcceso = Convert.ToDateTime(reader.ReadString());
                                break;


                        }
                    }
                    /* Si entramos por el ELSE lo unico que nos interesa saber es si es una Etiqueta de cierre para el Cierre
                     no nos interesa evaluar la etiqueta de cierre para los demas elementos*/
                    else if (reader.Name == "Cierre")
                    {
                        cierres.Add(cierre); //Agregamos el cierre a la lista.
                        cierre = null; //Lo seteamos en null para volver a comenzar con el siguiente Alumno
                    }
                }

                reader.Close(); //Cerramos el Reader. IMPORTANTE
                archivo.Close(); //Cerramos el Archivo. IMPORTANTE
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cierres;
        }
    }
}
