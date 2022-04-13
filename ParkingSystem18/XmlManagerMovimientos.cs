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
    class XmlManagerMovimientos
    {
        private string RutaArchivo3 = @"C:\ParkingSystem18\Movimientos.xml";

        public bool archivovacio()
        {

            FileStream archivo = new FileStream(RutaArchivo3, FileMode.Open, FileAccess.Read);
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

        public void GenerarXML(Movimiento movimiento)
        {
            try
            {
                if (archivovacio())
                {
                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo3, null);

                    //Le indicamos que el formato del XML debe ser indentado
                    writer.Formatting = Formatting.Indented;

                    //Damos comienzo al Documento
                    writer.WriteStartDocument();

                    //Ceramos una Etiqueta de apertura para Movimientos (Contenedor principal)
                    writer.WriteStartElement("Movimientos");


                    writer.WriteStartElement("Movimiento");

                    writer.WriteElementString("Concepto", movimiento.Concepto);
                    writer.WriteElementString("Importe", Convert.ToString(movimiento.Importe));
                    writer.WriteElementString("Fecha", Convert.ToString(movimiento.Fecha));
                    writer.WriteElementString("EsIngreso", Convert.ToString(movimiento.EsIngreso));

                    writer.WriteStartElement("Usuario");
                    writer.WriteElementString("User", movimiento.Usuario.User);
                    writer.WriteElementString("Password", movimiento.Usuario.Password);
                    writer.WriteElementString("UltAcceso", Convert.ToString(movimiento.Usuario.UltAcceso));
                    writer.WriteEndElement();


                    if (movimiento.Cierre != null)
                    {

                        writer.WriteStartElement("Cierre");


                        writer.WriteElementString("FechaCierre", Convert.ToString(movimiento.Cierre.Fecha));



                        writer.WriteStartElement("UsuarioCierre");
                        writer.WriteElementString("UserCierre", movimiento.Cierre.Usuario.User);
                        writer.WriteElementString("PasswordCierre", movimiento.Cierre.Usuario.Password);
                        writer.WriteElementString("UltAccesoCierre", Convert.ToString(movimiento.Cierre.Usuario.UltAcceso));
                        writer.WriteEndElement();


                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();


                    writer.WriteEndElement(); //Cerramos la Etiqueta contenedora Alquileres
                    writer.WriteEndDocument(); //Cerramos el Documento XML
                    writer.Flush(); //Limpiamos la cache
                    writer.Close(); //Cerramos el archivo
                } 
                else {
                    XDocument xDocument = XDocument.Load(RutaArchivo3);
                    XElement root = xDocument.Element("Movimientos");
                    IEnumerable<XElement> rows = root.Descendants("Movimiento");
                    XElement firstRow = rows.First();
                    if (movimiento.Cierre != null)
                    {
                        firstRow.AddBeforeSelf(

                           new XElement("Movimiento",
                               new XElement("Concepto", movimiento.Concepto),
                               new XElement("Importe", movimiento.Importe),
                               new XElement("Fecha", Convert.ToString(movimiento.Fecha)),
                               new XElement("EsIngreso", movimiento.EsIngreso),
                               new XElement("Usuario",
                                    new XElement("User", movimiento.Usuario.User),
                                    new XElement("Password", movimiento.Usuario.Password),
                                    new XElement("UltAcceso", Convert.ToString(movimiento.Usuario.UltAcceso))),
                               new XElement("Cierre",
                                    new XElement("FechaCierre", Convert.ToString(movimiento.Cierre.Fecha)),
                                    new XElement("UsuarioCierre",
                                        new XElement("UserCierre", movimiento.Cierre.Usuario.User),
                                        new XElement("PasswordCierre", movimiento.Cierre.Usuario.Password),
                                        new XElement("UltAccesoCierre", movimiento.Cierre.Usuario.UltAcceso)
                                      ))));
                    }
                    else
                    {
                        firstRow.AddBeforeSelf(
                           new XElement("Movimiento",
                            new XElement("Concepto", movimiento.Concepto),
                            new XElement("Importe", movimiento.Importe),
                            new XElement("Fecha", Convert.ToString(movimiento.Fecha)),
                            new XElement("EsIngreso", movimiento.EsIngreso),
                            new XElement("Usuario",
                                 new XElement("User", movimiento.Usuario.User),
                                 new XElement("Password", movimiento.Usuario.Password),
                                 new XElement("UltAcceso", Convert.ToString(movimiento.Usuario.UltAcceso))))); }
                    xDocument.Save(RutaArchivo3);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Movimiento> ObtenerMovimientos()
        {
            List<Movimiento> movimientos = new List<Movimiento>();

            try
            {
                //Preparamos el archivo XML para lectura
                FileStream archivo = new FileStream(RutaArchivo3, FileMode.Open, FileAccess.Read);

                //Le asignamos un XmlTextReader
                XmlTextReader reader = new XmlTextReader(archivo);

                //Inicializamos un objeto de cada tipo en null
                Movimiento movimiento = null;


                //Comenzamos el recorrido por el archivo
                while (reader.Read())
                {
                    //Si la etiqueta que estamos leyendo,corresponde a la Apertura de un elemento...
                    if (reader.IsStartElement())
                    {
                        //Comprobamos qué tipo de etiqueta estamos leyendo
                        switch (reader.Name)
                        {
                            case "Movimientos":
                                break;

                            case "Movimiento": //cierre, creamos un nuevo cierre
                                movimiento = new Movimiento();
                                break;

                            case "Usuario":
                                movimiento.Usuario = new Usuario(); //Instanciamos un Objeto usuario y lo asignamos al cierre
                                break;

                            case "User":
                                movimiento.Usuario.User = Convert.ToString(reader.ReadString());
                                break;

                            case "Password":
                                movimiento.Usuario.Password =Convert.ToString(reader.ReadString());
                                break;

                            case "UltAcceso":
                                movimiento.Usuario.UltAcceso = Convert.ToDateTime(reader.ReadString());
                                break;

                            case "Cierre": //cierre, creamos un nuevo cierre
                                movimiento.Cierre = new Cierre();
                                break;

                            case "UsuarioCierre":
                                movimiento.Cierre.Usuario = new Usuario(); //Instanciamos un Objeto usuario y lo asignamos al cierre
                                break;

                            case "FechaCierre":
                                if (reader.Read())
                                    movimiento.Cierre.Fecha = Convert.ToDateTime(reader.ReadString()); //Asignamos fecha al cierre
                                break;

                            case "UserCierre": //Asignamos User a al Usuario del Cierre
                                if (reader.Read())
                                    movimiento.Cierre.Usuario.User = Convert.ToString(reader.ReadString());
                                break;

                            case "PasswordCierre": //Asignamos password al usuario del Cierre
                                if (reader.Read())
                                    movimiento.Cierre.Usuario.Password = Convert.ToString(reader.ReadString());
                                break;

                            case "UltAccesoCierre": //Asignamos fecha al usuario del Cierre
                                if (reader.Read())
                                    movimiento.Cierre.Usuario.UltAcceso = Convert.ToDateTime(reader.ReadString());
                                break;

                            case "Concepto":
                                if (reader.Read())
                                    movimiento.Concepto = Convert.ToString(reader.ReadString());
                                break;

                            case "Importe":
                                if (reader.Read())
                                    movimiento.Importe = Convert.ToDouble(reader.ReadString());
                                break;

                            case "Fecha":
                                if (reader.Read())
                                    movimiento.Fecha = Convert.ToDateTime(reader.ReadString());
                                break;

                            case "EsIngreso":
                                if (reader.Read())
                                    movimiento.EsIngreso = Convert.ToBoolean(reader.ReadString());
                                break;


                        }
                    }
                    /* Si entramos por el ELSE lo unico que nos interesa saber es si es una Etiqueta de cierre para el Cierre
                     no nos interesa evaluar la etiqueta de cierre para los demas elementos*/
                    else if (reader.Name == "Movimiento")
                    {
                        movimientos.Add(movimiento); //Agregamos el cierre a la lista.
                        movimiento = null; //Lo seteamos en null para volver a comenzar con el siguiente Alumno
                    }
                }

                reader.Close(); //Cerramos el Reader. IMPORTANTE
                archivo.Close(); //Cerramos el Archivo. IMPORTANTE
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return movimientos;
        }
    }
}
