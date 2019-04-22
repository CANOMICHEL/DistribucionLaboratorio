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
        #region atributos
        cUsuario user = new cUsuario();
        #endregion atributos

        #region constructor
        public FrmAdmin()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region eventos


        #endregion eventos

        #region metodos
        public void CargarDatosUsuario(string usuario)
        {
            DataTable dt = user.Datos(usuario);
            lblNombre.Text += " " + dt.Rows[0][0];
            lblApellidos.Text += " " + dt.Rows[0][1] + " " + dt.Rows[0][2];
            lblDNI.Text += " " + dt.Rows[0][3];
        }
        #endregion metodos
        private void AsignarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAsignacion()).Show();
        }

        

        private void AñadirUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmAñadirUsuario()).Show();
        }

        private void SuspenderUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAñadirUsuario frm = new FrmAñadirUsuario();
            frm.Cambiar_Nombre_Titulo("Suspender Usuario",
                "Suspender Usuario");
        }


        //private void Datos()
        //{
        //    DataTable dt = user.DatosUsuario("");
        //}
    }
}
