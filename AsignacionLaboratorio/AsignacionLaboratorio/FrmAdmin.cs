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
    public partial class FrmAdmin : Form
    {
        cUsuario user = new cUsuario();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void AsignarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAsignacion()).Show();
        }

        public void CargarDatosUsuario(string usuario)
        {
            DataTable dt = user.Datos(usuario);
            lblNombre.Text += " " + dt.Rows[0][0];
            lblApellidos.Text += " " + dt.Rows[0][1] + " " + dt.Rows[0][2];
            lblDNI.Text += " " + dt.Rows[0][3];
        }

        private void AñadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAñadirUsuario()).Show();
        }


        //private void Datos()
        //{
        //    DataTable dt = user.DatosUsuario("");
        //}
    }
}
