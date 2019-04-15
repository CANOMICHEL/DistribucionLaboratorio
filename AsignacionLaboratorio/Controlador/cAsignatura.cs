using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using System.Windows.Forms;
namespace Controlador
{
    
    public class cAsignatura:cEntidad
    {
        public cAsignatura() { }


        public void TAsignatura_dgv(DataGridView dgv)
        {
            dgv.DataSource = dc.TAsignatura;
        }
    }
}
