﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NovoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cadastro_marca().ShowDialog();
            this.Visible = true;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cadastro_loja().ShowDialog();
            this.Visible = true; 
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new cadastro_produto().ShowDialog();
            this.Visible = true;
        }

        private void lojaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new atualiza_loja().ShowDialog();
            this.Visible = true;
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new atualiza_produto().ShowDialog();
            this.Visible = true;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new delete_produto().ShowDialog();
            this.Visible = true;
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new delete_marca().ShowDialog();
            this.Visible = true;
        }

        private void lojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new delete_loja().ShowDialog();
            this.Visible = true;
        }

        private void marcaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new atualiza_marca().ShowDialog();
            this.Visible = true;
        }

        private void porLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new visualizador_produto_loja().ShowDialog();
            this.Visible = true;
        }
    }
}
