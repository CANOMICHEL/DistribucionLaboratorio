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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void tbUser_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Usuario")
            {
                tb.Clear();
                tb.ForeColor = Color.Black;

            }
            if (tb.Text == "Contraseña")
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
                tb.UseSystemPasswordChar = true;
            }

        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "" & tbPassword.Text == "Contraseña")
            {
                tbUser.Text = "Usuario";
                tb.ForeColor = Color.Gray;
            }
            if (tb.Text == "" & tbUser.Text == "Usuario")
            {
                tb.UseSystemPasswordChar = false;
                tbPassword.Text = "Contraseña";
                tb.ForeColor = Color.Gray;
            }
        }

        private void adminnistradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelLogin.Enabled = true;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            cUsuario user = new cUsuario();
            if (user.ValidarUsuario(tbUser.Text,tbPassword.Text))
            {
                (new FrmAsignacion()).Show();
            }
            else
            {
                MessageBox.Show("ERROR DE AUTENTICACIÓN\nEl nombre de usuario o contraseña no son Válidos");
            }

            
        }
    }
}
