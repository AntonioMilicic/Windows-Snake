﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void StartingGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SnakeForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
