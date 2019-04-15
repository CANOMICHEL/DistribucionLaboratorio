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
        public FrmAsignacion()
        {
            InitializeComponent();
        }
        #region Metodos
        //private void 
        #endregion Metodos

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAsignacion_Load(object sender, EventArgs e)
        {
            cLaboratorio Lab = new cLaboratorio();
            Lab.TLaboratorio(dgvDatosHorario);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
