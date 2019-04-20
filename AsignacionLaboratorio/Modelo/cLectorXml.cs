using System;
using System.Xml;

namespace Modelo
{
    public class cLectorXml
    {
        public string cadenaConexion()
        {
            string cad = "";
            XmlTextReader lector = new XmlTextReader(@"F:\AsignacionLaboratorio2\Modelo\docXML\XMLFile1.xml");
            while (lector.Read())
            {

                switch (lector.NodeType)
                {
                    case XmlNodeType.Text: 
                        cad = lector.Value;
                        break;
                }
            }
            return cad;
        }
    }
}
