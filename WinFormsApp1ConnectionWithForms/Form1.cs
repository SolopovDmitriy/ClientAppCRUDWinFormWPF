﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1ConnectionWithForms
{
    public partial class form_to_form : Form
    {
        public form_to_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.textBox1.Text = this.textBox1.Text + " - 1";
            fm2.Txt = this.textBox1.Text + " - 2";
            //
            fm2.ShowDialog();
        }
    }
}
