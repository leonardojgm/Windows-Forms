using System;
using System.Windows.Forms;

namespace _05___TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackBar1.Maximum = 100;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.Text = this.trackBar1.Value.ToString();
        }
    }
}
