using System;
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
    public partial class Form2 : Form
    {
        public string Txt
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
