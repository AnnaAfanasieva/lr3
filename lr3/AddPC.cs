﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class AddPC : Form
    {

        Computer comp;
        public AddPC(Computer computer)
        {
            comp = computer;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp.compnames = textBox1.Text;
            this.Close();
        }
    }
}
