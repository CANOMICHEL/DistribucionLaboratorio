namespace AsignacionLaboratorio
{
    partial class FrmAñadirUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbEstado);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.tbAM);
            this.panel1.Controls.Add(this.tbAP);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbDNI);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 375);
            this.panel1.TabIndex = 0;
            // 
            // btnAñadir
            // 
            this.btnAñadir.AutoSize = true;
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Location = new System.Drawing.Point(365, 333);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(124, 30);
            this.btnAñadir.TabIndex = 9;
            this.btnAñadir.Text = "Añadir Usuario";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(234, 234);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(243, 26);
            this.tbAM.TabIndex = 8;
            this.tbAM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presionarteclatexto);
            this.tbAM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbAM_KeyUp);
            this.tbAM.Validating += new System.ComponentModel.CancelEventHandler(this.ControlarTexto);
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(234, 181);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(243, 26);
            this.tbAP.TabIndex = 7;
            this.tbAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presionarteclatexto);
            this.tbAP.Validating += new System.ComponentModel.CancelEventHandler(this.ControlarTexto);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(234, 128);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(243, 26);
            this.tbNombre.TabIndex = 6;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presionarteclatexto);
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.ControlarTexto);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(234, 75);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(243, 26);
            this.tbDNI.TabIndex = 5;
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDNI);
            this.tbDNI.Validating += new System.ComponentModel.CancelEventHandler(this.ControlarTexto);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INGRESE LOS DATOS DEL NUEVO USUARIO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Checked = true;
            this.chbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEstado.Location = new System.Drawing.Point(234, 266);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(71, 24);
            this.chbEstado.TabIndex = 10;
            this.chbEstado.Text = "Activo";
            this.chbEstado.UseVisualStyleBackColor = true;
            this.chbEstado.CheckedChanged += new System.EventHandler(this.ChbEstado_CheckedChanged);
            // 
            // FrmAñadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 375);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAñadirUsuario";
            this.Text = "Añadir Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.CheckBox chbEstado;
    }
}