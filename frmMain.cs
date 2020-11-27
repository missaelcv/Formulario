﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTarea9
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistroEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistroEstudiantes registro = new RegistroEstudiantes();
            registro.StartPosition = FormStartPosition.CenterParent;
            registro.MdiParent = this;
            registro.Show();
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegistroEstudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmRegistroEstudiantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea Salir del Sistema?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void matenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado registro = new frmRegistroEmpleado();
            registro.StartPosition = FormStartPosition.CenterParent;
            registro.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProfesor registro = new frmRegistroProfesor();
            registro.StartPosition = FormStartPosition.CenterParent;
            registro.Show();
        }
    }
    }
