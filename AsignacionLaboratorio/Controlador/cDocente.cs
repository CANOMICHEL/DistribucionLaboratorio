using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class cDocente : cEntidad
    {
        conexionDataContext dc = new conexionDataContext();
        public cDocente()
            : base("TDocente")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente", "Nombre"};
        }

        public DataTable ListarDocentes()
        {
            string consulta = "exec spuTDocente_Listar";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ultimo()
        {
            string consulta = "exec spuTDocente_Ultimo";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

        public void Insertar()
        {
            dc.spuTDocente_Insertar("1234", "manuel");
        }
    }
}
