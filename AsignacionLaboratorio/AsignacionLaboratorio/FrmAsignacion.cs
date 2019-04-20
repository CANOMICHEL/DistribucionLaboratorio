using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace AsignacionLaboratorio
{
    public partial class FrmAsignacion : Form
    {
        cAsignatura aAsignatura = new cAsignatura();
        public FrmAsignacion()
        {
            InitializeComponent();
        }

        private void FrmAsignacion_Load(object sender, EventArgs e)
        {
            ListarHorario();
        }

        #region Metodos

        private void ListarHorario()
        {
            cboAsignatura.DataSource = aAsignatura.Tabla();
            cboAsignatura.DisplayMember = "NombreAsignatura";
            cboAsignatura.ValueMember = "CodAsignatura";
        }

        #endregion Metodos

    }
}
