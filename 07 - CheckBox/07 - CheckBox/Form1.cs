using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07___CheckBox
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string config = string.Empty;

            if (this.checkBox1.Checked) config += "Compressão: Alta";
            else config += "Compressão: Baixa";

            if (this.checkBox2.Checked) config += "\nZIP: Habilitado";
            else config += "\nZIP: Desabilitado";

            if (this.checkBox3.Checked) config += "\nDividir em Partes: Habilitado";
            else config += "\nDividir em Partes: Desabilitado";

            this.label1.Text = config;
        }
    }
}
