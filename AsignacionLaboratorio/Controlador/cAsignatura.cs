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

        public DataTable Tabla()
        {
            var vrasignatura = from asignatura in dc.TAsignatura
                         select new
                         {
                             asignatura.CodAsignatura,
                             asignatura.NombreAsignatura,
                             asignatura.Creditos,
                             asignatura.Categoria
                         };
            DataTable dt = ToDataTable(dc, vrasignatura);
            return dt;
        }
    }
}
