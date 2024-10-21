using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06___ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value >= 100)
                this.timer1.Enabled = false;
            else
                this.progressBar1.Value += 1;
        }
    }
}
