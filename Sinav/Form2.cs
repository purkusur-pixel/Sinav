﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav
{
    public partial class Form2 : Form
    {
        public Form2(string labelText)
        {
            InitializeComponent();

            // Update label_gogus with the passed value
            label1.Text = labelText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
