using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18___ColorDialog
{
    public partial class Form1 : Form
    {
        private ColorDialog selecionarCor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selecionarCor.ShowDialog() == DialogResult.OK) this.BackColor = selecionarCor.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selecionarCor = new ColorDialog();
        }
    }
}
