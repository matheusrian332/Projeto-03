﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03__Senai
{
    public partial class FormTabelaNecessidades : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        public FormTabelaNecessidades()
        {
            InitializeComponent();
        }

        ClassNecessidadesEmpresa necessidades = new ClassNecessidadesEmpresa();

        private void FormTabelaNecessidades_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = necessidades.MostrarNecessidade();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }
    }
}
