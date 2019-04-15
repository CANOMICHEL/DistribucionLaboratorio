using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Controlador
{
    public class cHorario : cEntidad
    {
        public cHorario() { }

        public DataTable Tabla()
        {
            DataGridView dgv = new DataGridView();
            dgv.DataSource = dc.THorario;
            return dgv.DataSource as DataTable;
        }
    }
}
