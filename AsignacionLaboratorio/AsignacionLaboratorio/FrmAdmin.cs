﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionLaboratorio
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void AsignarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                (new FrmAsignacion()).Show();
            }
            catch (Exception ex){}
        }
    }
}