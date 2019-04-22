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
        #region constructor
        public Inicio()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region eventos
        private void TextBox_Enter(object sender, EventArgs e)
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

        private void TextBox_Leave(object sender, EventArgs e)
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
            PanelLogin.Visible = true;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            cUsuario user = new cUsuario();

            if (user.ValidarUsuario(tbUser.Text,tbPassword.Text))
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
                admin.CargarDatosUsuario(tbUser.Text);
                Reestablecer();
            }
            else
            {
                MessageBox.Show("ERROR DE AUTENTICACIÓN\nEl nombre de usuario o contraseña no son Válidos");
         
            }

            
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion eventos

        #region metodos
        private void Reestablecer()
        {
            tbUser.Text = "Usuario";
            tbUser.ForeColor = Color.Gray;
            tbPassword.UseSystemPasswordChar = false;
            tbPassword.Text = "Contraseña";
            tbPassword.ForeColor = Color.Gray;
        }

        #endregion metodos

        

        
    }
}
