using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20___Relogio
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            Color cor = Color.FromArgb(r, g, b);

            this.label1.ForeColor = cor;
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
