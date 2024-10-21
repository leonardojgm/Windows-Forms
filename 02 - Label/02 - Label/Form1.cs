using System;
using System.Drawing;
using System.Windows.Forms;

namespace _02___Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Campo foi clicado!";
            label1.ForeColor = Color.Red;
        }
    }
}
