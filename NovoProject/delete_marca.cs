﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoProject
{
    public partial class delete_marca : Form
    {
        Control control = new Control();
        public delete_marca()
        {
            InitializeComponent();
        }

        private void delete_marca_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = control.selectMarca();
            listBox1.ValueMember = "codMarca";
            listBox1.DisplayMember = "nome";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                control.delete_marca(Int32.Parse(listBox1.SelectedValue.ToString()));
                control.selectMarca();
            }
            else
            {
                MessageBox.Show("Confirme a operaçao");
            }
            
        }
    }
}
