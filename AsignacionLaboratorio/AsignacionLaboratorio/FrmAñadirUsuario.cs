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
    public partial class FrmAñadirUsuario : Form
    {
        cUsuario user = new cUsuario();
        public FrmAñadirUsuario()
        {
            InitializeComponent();
        }

        private void presionarteclatexto(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ValidarDNI(object sender, KeyPressEventArgs e)
        {
            int tecla = e.KeyChar;
            if (tecla != 8){
                if (tecla < 48 | tecla > 57)
                    e.Handled = true;
                if ((sender as TextBox).Text.Length >= 8){
                    e.Handled = true;
                    if (Char.IsControl(e.KeyChar))
                        e.Handled = false;
                }
            }
        }

        private void ControlarTexto(object sender, CancelEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (tb.Text.Length == 0){
                tb.Focus();
                this.errorProvider1.SetError(tb, "Este campo debe ser llenado");
            }
            else if (tb.Name == "tbDNI"){
                if (tb.Text.Length < 8){
                    tb.Focus();
                    this.errorProvider1.SetError(tb, "Complete el DNI");
                }
            }

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            string Contraseña = user.GenerarContraseña();
            user.InsertarNuevoUsuario(tbDNI.Text, tbNombre.Text,tbAP.Text,tbAM.Text,Contraseña);
            MessageBox.Show("usuario registrado exitosamente\n" +
                "Su nombre de usuario es: "+tbDNI.Text+"\n" +
                "Su contraseña es: "+Contraseña);
            
        }

        private void TbAM_KeyUp(object sender, KeyEventArgs e)
        {
            if(tbAM.Text=="")
                btnAñadir.Enabled = false;
            else
                btnAñadir.Enabled = true;
        }
    }



    
}
