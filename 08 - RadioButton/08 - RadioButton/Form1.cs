using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08___RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var config = string.Empty;

            if (this.radioButton1.Checked) config = "Baixo";

            else if (this.radioButton2.Checked) config = "Medio";

            else if (this.radioButton3.Checked) config = "Alto";

            else config = "Não selecionado";

            MessageBox.Show(config);
        }
    }
}
