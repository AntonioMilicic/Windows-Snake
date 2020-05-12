using System;
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
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new SnakeForm().Show();
        }

        private void NameScoreTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScoreTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
