﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(textBox1.Text);
            var b = Convert.ToInt32(textBox2.Text);
            var c = a + b;
            MessageBox.Show(c.ToString());
        }
    }
}
