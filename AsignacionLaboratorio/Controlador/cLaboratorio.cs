using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using System.Windows.Forms;
namespace Controlador
{
    public class cLaboratorio : cEntidad
    {
        public cLaboratorio() { }

        public void TLaboratorio(DataGridView dgv)
        {
            //DataGridView dgv = new DataGridView();
            dgv.DataSource = dc.THorario;
            //return dgv.DataSource as DataTable;
        }

        //public void TLaboratorio_cb(ComboBox cb)
        //{
        //    cb.DataSource = dc.TLaboratorio;
        //}

        //private void Tabla()
        //{
        //    DataTable tabla=dc.TLaboratorio as DataTable;
        //}

    }
}
