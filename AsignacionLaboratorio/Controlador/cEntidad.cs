using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Modelo;

namespace Controlador
{
    public class cEntidad
    {
        public conexionDataContext dc = new conexionDataContext();

        public cEntidad()
        {
        }

    }
}
