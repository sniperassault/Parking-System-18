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
    class XmlManagerAlquileres
    {
        private string RutaArchivo = @"C:\ParkingSystem18\Alquileres.xml";

        public void CargarTodo(List<Alquiler> lista)
        {
            File.WriteAllText(RutaArchivo, "");
            if (lista.Count > 0)
            {
                foreach (Alquiler aux in lista)
                { GenerarXML(aux); }
            }
          
            
                                  
        }
        public bool archivovacio()
        {

            FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
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
        public void GenerarXML(Alquiler alquiler)
        {
            try
            {

                if (archivovacio())
                {
                    XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);

                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Alquileres");

                    writer.WriteStartElement("Alquiler");


                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();


                    XDocument xDocument = XDocument.Load(RutaArchivo);
                    XElement root = xDocument.Element("Alquileres");
                    if (alquiler is AlquilerHora)
                    {
                        IEnumerable<XElement> rows = root.Descendants("Alquiler");
                        XElement firstRow = rows.First();
                        AlquilerHora hora = alquiler as AlquilerHora;
                        firstRow.AddBeforeSelf(
                            new XElement("Alquiler",
                                new XElement("AlquilerHora",
                                    new XElement("Fecha", Convert.ToString(hora.Fecha)),
                                    new XElement("HoraIngreso", Convert.ToString(hora.Desde)),
                                    new XElement("Cochera",
                                        new XElement("Id", hora.Cochera.Id),
                                        new XElement("Estado", hora.Cochera.Estado),
                                        new XElement("Vehiculo",
                                            new XElement("Dominio", hora.Cochera.Vehiculo.Dominio),
                                            new XElement("Marca", hora.Cochera.Vehiculo.Marca),
                                            new XElement("Modelo", hora.Cochera.Vehiculo.Modelo),
                                            new XElement("TipoVehiculo",
                                                new XElement("Codigo", hora.Cochera.Vehiculo.Tipovehiculo.Codigo),
                                                new XElement("Descripcion", hora.Cochera.Vehiculo.Tipovehiculo.Descripcion)))))));
                    }

                    else
                    {
                        IEnumerable<XElement> rows = root.Descendants("Alquiler");
                        XElement firstRow = rows.First();
                        AlquilerMensual mensual = alquiler as AlquilerMensual;
                        firstRow.AddBeforeSelf(

                             new XElement("Alquiler",
                               new XElement("AlquilerMensual",
                                    new XElement("Fecha", Convert.ToString(mensual.Fecha)),
                                    new XElement("Titular", mensual.Titular),
                                    new XElement("FechaVencimiento", Convert.ToString(mensual.Fechavencimiento)),
                                    new XElement("Cochera",
                                        new XElement("Id", mensual.Cochera.Id),
                                        new XElement("Estado", mensual.Cochera.Estado),
                                        new XElement("Vehiculo",
                                            new XElement("Dominio", mensual.Cochera.Vehiculo.Dominio),
                                            new XElement("Marca", mensual.Cochera.Vehiculo.Marca),
                                            new XElement("Modelo", mensual.Cochera.Vehiculo.Modelo),
                                            new XElement("TipoVehiculo",
                                                new XElement("Codigo", mensual.Cochera.Vehiculo.Tipovehiculo.Codigo),
                                                new XElement("Descripcion", mensual.Cochera.Vehiculo.Tipovehiculo.Descripcion)))))));
                    }
                    xDocument.Save(RutaArchivo);
                }
                else
                {
                    XDocument xDocument = XDocument.Load(RutaArchivo);
                    XElement root = xDocument.Element("Alquileres");
                    if (alquiler is AlquilerHora)
                    {
                        IEnumerable<XElement> rows = root.Descendants("Alquiler");
                        XElement firstRow = rows.First();
                        AlquilerHora hora = alquiler as AlquilerHora;
                        firstRow.AddBeforeSelf(
                             new XElement("Alquiler",
                                new XElement("AlquilerHora",
                                    new XElement("Fecha", Convert.ToString(hora.Fecha)),
                                    new XElement("HoraIngreso", Convert.ToString(hora.Desde)),
                                    new XElement("Cochera",
                                        new XElement("Id", hora.Cochera.Id),
                                        new XElement("Estado", hora.Cochera.Estado),
                                        new XElement("Vehiculo",
                                            new XElement("Dominio", hora.Cochera.Vehiculo.Dominio),
                                            new XElement("Marca", hora.Cochera.Vehiculo.Marca),
                                            new XElement("Modelo", hora.Cochera.Vehiculo.Modelo),
                                            new XElement("TipoVehiculo",
                                                new XElement("Codigo", hora.Cochera.Vehiculo.Tipovehiculo.Codigo),
                                                new XElement("Descripcion", hora.Cochera.Vehiculo.Tipovehiculo.Descripcion)))))));
                    }

                    else
                    {
                        IEnumerable<XElement> rows = root.Descendants("Alquiler");
                        XElement firstRow = rows.First();
                        AlquilerMensual mensual = alquiler as AlquilerMensual;
                        firstRow.AddBeforeSelf(
                             new XElement("Alquiler",

                               new XElement("AlquilerMensual",
                                    new XElement("Fecha", Convert.ToString(mensual.Fecha)),
                                    new XElement("Titular", mensual.Titular),
                                    new XElement("FechaVencimiento", Convert.ToString(mensual.Fechavencimiento)),
                                    new XElement("Cochera",
                                        new XElement("Id", mensual.Cochera.Id),
                                        new XElement("Estado", mensual.Cochera.Estado),
                                        new XElement("Vehiculo",
                                            new XElement("Dominio", mensual.Cochera.Vehiculo.Dominio),
                                            new XElement("Marca", mensual.Cochera.Vehiculo.Marca),
                                            new XElement("Modelo", mensual.Cochera.Vehiculo.Modelo),
                                            new XElement("TipoVehiculo",
                                                new XElement("Codigo", mensual.Cochera.Vehiculo.Tipovehiculo.Codigo),
                                                new XElement("Descripcion", mensual.Cochera.Vehiculo.Tipovehiculo.Descripcion)))))));
                    }
                    xDocument.Save(RutaArchivo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Alquiler> ObtenerAlquileres()
        {
            List<Alquiler> ListaAlquileres = new List<Alquiler>();

            try
            {
                FileStream archivo = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);

                XmlTextReader reader = new XmlTextReader(archivo);

                Alquiler alquiler = null;
                AlquilerHora hora = null;
                AlquilerMensual mes = null;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Alquileres":
                                break;

                            case "Alquiler":
                                break;

                            case "AlquilerHora":
                                alquiler = new AlquilerHora();
                                break;

                            case "AlquilerMensual":
                                alquiler = new AlquilerMensual();
                                break;

                            case "Fecha":
                                if (reader.Read())
                                {
                                    alquiler.Fecha = Convert.ToDateTime(reader.ReadString());
                                }
                                break;

                            case "HoraIngreso":
                                if (reader.Read())
                                {
                                    hora = alquiler as AlquilerHora;
                                    hora.Desde = Convert.ToDateTime(reader.ReadString());
                                }
                                break;

                            case "Titular":
                                if (reader.Read())
                                {
                                    mes = alquiler as AlquilerMensual;
                                    mes.Titular = reader.ReadString();
                                }
                                break;

                            case "FechaVencimiento":
                                if (reader.Read())
                                {
                                    mes = alquiler as AlquilerMensual;
                                    mes.Fechavencimiento = Convert.ToDateTime(reader.ReadString());
                                }
                                break;

                            case "Cochera":
                                alquiler.Cochera = new Cochera();
                                break;

                            case "Id":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Id = Convert.ToInt32(reader.ReadString());
                                }
                                break;

                            case "Estado":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Estado = Convert.ToBoolean(reader.ReadString());
                                }
                                break;

                            case "Vehiculo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo = new Vehiculo();
                                }
                                break;

                            case "Dominio":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Dominio = reader.ReadString();
                                }
                                break;

                            case "Marca":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Marca = reader.ReadString();
                                }
                                break;

                            case "Modelo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Modelo = reader.ReadString();
                                }
                                break;

                            case "TipoVehiculo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Tipovehiculo = new TipoVehiculo();
                                }
                                break;

                            case "Codigo":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Tipovehiculo.Codigo = reader.ReadString();
                                }
                                break;

                            case "Descripcion":
                                if (reader.Read())
                                {
                                    alquiler.Cochera.Vehiculo.Tipovehiculo.Descripcion = reader.ReadString();
                                }
                                break;
                        }
                    }
                    else
                    {
                        if (reader.Name == "AlquilerHora" || reader.Name == "AlquilerMensual")
                        {
                            ListaAlquileres.Add(alquiler);
                            alquiler = null;
                        }
                    }
                }
                reader.Close();
                archivo.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ListaAlquileres;
        }
    }
}
