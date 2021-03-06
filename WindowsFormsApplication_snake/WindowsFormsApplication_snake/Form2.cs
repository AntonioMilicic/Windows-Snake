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
    public partial class SaveScoreForm : Form
    {
        public SaveScoreForm()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GoToHigh_Click(object sender, EventArgs e)
        {
            this.Close();
            new HighScoreForm().Show();
        }

        private void GoToGame_Click(object sender, EventArgs e)
        {
            this.Close();  
            new SnakeForm().Show();
        }

        private void Label_Joke_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wowwiki.wikia.com/wiki/Soon");
        }
    }
}
