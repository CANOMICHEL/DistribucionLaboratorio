namespace AsignacionLaboratorio
{
    partial class FrmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspenderUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosSinAsignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDNI);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(445, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 450);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 450);
            this.panel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(143, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(159, 185);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 20);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarLaboratorioToolStripMenuItem,
            this.añadirUsuarioToolStripMenuItem,
            this.suspenderUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.administradorToolStripMenuItem.Text = "Inicio";
            // 
            // asignarLaboratorioToolStripMenuItem
            // 
            this.asignarLaboratorioToolStripMenuItem.Name = "asignarLaboratorioToolStripMenuItem";
            this.asignarLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.asignarLaboratorioToolStripMenuItem.Text = "Asignar Laboratorio";
            this.asignarLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.AsignarLaboratorioToolStripMenuItem_Click);
            // 
            // añadirUsuarioToolStripMenuItem
            // 
            this.añadirUsuarioToolStripMenuItem.Name = "añadirUsuarioToolStripMenuItem";
            this.añadirUsuarioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.añadirUsuarioToolStripMenuItem.Text = "Añadir Usuario";
            // 
            // suspenderUsuarioToolStripMenuItem
            // 
            this.suspenderUsuarioToolStripMenuItem.Name = "suspenderUsuarioToolStripMenuItem";
            this.suspenderUsuarioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.suspenderUsuarioToolStripMenuItem.Text = "Suspender Usuario";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.salirToolStripMenuItem.Text = "Modificar datos de Usuario";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horariosSinAsignarToolStripMenuItem,
            this.laboratoriosDisponiblesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // horariosSinAsignarToolStripMenuItem
            // 
            this.horariosSinAsignarToolStripMenuItem.Name = "horariosSinAsignarToolStripMenuItem";
            this.horariosSinAsignarToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.horariosSinAsignarToolStripMenuItem.Text = "Horarios sin asignar";
            // 
            // laboratoriosDisponiblesToolStripMenuItem
            // 
            this.laboratoriosDisponiblesToolStripMenuItem.Name = "laboratoriosDisponiblesToolStripMenuItem";
            this.laboratoriosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.laboratoriosDisponiblesToolStripMenuItem.Text = "Laboratorios Disponibles";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspenderUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosSinAsignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
    }
}