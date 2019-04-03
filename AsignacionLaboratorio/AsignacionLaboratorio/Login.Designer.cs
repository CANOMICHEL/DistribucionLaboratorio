namespace AsignacionLaboratorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminnistradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosPorLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosSinLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbUser);
            this.panel2.Controls.Add(this.btnAcceder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(64, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 260);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 212);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo.Location = new System.Drawing.Point(212, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(72, 24);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "LOGIN";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbPassword.Location = new System.Drawing.Point(43, 140);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(379, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "_______________________________________________________________\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.SystemColors.Control;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbUser.Location = new System.Drawing.Point(44, 82);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(378, 22);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "Usuario";
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // btnAcceder
            // 
            this.btnAcceder.AutoSize = true;
            this.btnAcceder.BackColor = System.Drawing.Color.Silver;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcceder.Location = new System.Drawing.Point(116, 198);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(288, 36);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseMnemonic = false;
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "_______________________________________________________________\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accederToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accederToolStripMenuItem
            // 
            this.accederToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminnistradorToolStripMenuItem});
            this.accederToolStripMenuItem.Name = "accederToolStripMenuItem";
            this.accederToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.accederToolStripMenuItem.Text = "Acceder";
            // 
            // adminnistradorToolStripMenuItem
            // 
            this.adminnistradorToolStripMenuItem.Name = "adminnistradorToolStripMenuItem";
            this.adminnistradorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adminnistradorToolStripMenuItem.Text = "Adminnistrador";
            this.adminnistradorToolStripMenuItem.Click += new System.EventHandler(this.adminnistradorToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosPorLaboratorioToolStripMenuItem,
            this.laboratoriosDisponiblesToolStripMenuItem,
            this.cursosSinLaboratorioToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cursosPorLaboratorioToolStripMenuItem
            // 
            this.cursosPorLaboratorioToolStripMenuItem.Name = "cursosPorLaboratorioToolStripMenuItem";
            this.cursosPorLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cursosPorLaboratorioToolStripMenuItem.Text = "Cursos por laboratorio";
            // 
            // laboratoriosDisponiblesToolStripMenuItem
            // 
            this.laboratoriosDisponiblesToolStripMenuItem.Name = "laboratoriosDisponiblesToolStripMenuItem";
            this.laboratoriosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.laboratoriosDisponiblesToolStripMenuItem.Text = "Laboratorios disponibles";
            // 
            // cursosSinLaboratorioToolStripMenuItem
            // 
            this.cursosSinLaboratorioToolStripMenuItem.Name = "cursosSinLaboratorioToolStripMenuItem";
            this.cursosSinLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cursosSinLaboratorioToolStripMenuItem.Text = "Asignaturas sin Laboratorio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accederToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminnistradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosPorLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosSinLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}