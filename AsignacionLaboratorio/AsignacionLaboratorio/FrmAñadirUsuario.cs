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
                    if (char.IsControl(e.KeyChar))
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
            if(tbDNI.Text!="" & tbNombre.Text!="" &tbAP.Text!="" & tbAM.Text != "") {
                string Contraseña = user.GenerarContraseña();
                user.InsertarNuevoUsuario(tbDNI.Text, tbNombre.Text, tbAP.Text, tbAM.Text, Contraseña,chbEstado.Text);
                MessageBox.Show("usuario registrado exitosamente\n" +
                    "Su nombre de usuario es: " + tbDNI.Text + "\n" +
                    "Su contraseña es: " + Contraseña);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos.");
            }
            
        }

        private void Limpiar()
        {
            tbDNI.Clear();
            tbNombre.Clear();
            tbAP.Clear();
            tbAM.Clear();
        }

        private void TbAM_KeyUp(object sender, KeyEventArgs e)
        {
            if(tbAM.Text=="")
                btnAñadir.Enabled = false;
            else
                btnAñadir.Enabled = true;
        }

        public void Cambiar_Nombre_Titulo(string Nombre,string Titulo)
        {
            this.Text = Nombre;
            lblTitulo.Text = Titulo;
        }

        private void ChbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == false)
                (sender as CheckBox).Text = "Desactivado";
            else
                (sender as CheckBox).Text = "Activo";
        }

        public void FuncionSuspender(string CodUsuario)
        {

        }

        public void ModificarDatosUsuario(string CodUsuario)
        {
            
        }

        private void RecuperarDatos(string CodUsuario)
        {
            DataTable dt = user.Datos(CodUsuario);
            if (dt.Rows.Count != 0){
                tbDNI.Enabled = false;
                tbNombre.Text = dt.Rows[0][0].ToString();
                tbAP.Text = dt.Rows[0][1].ToString();
                tbAM.Text = dt.Rows[0][2].ToString();
            }
            else { 
                MessageBox.Show("No se pudo completar los datos \n " +
                    "Usuario con DNI: "+CodUsuario+" no existe");
                Limpiar();
            }
        }
    }



    
}
