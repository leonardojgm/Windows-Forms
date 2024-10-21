using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }

            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.comboBox1.SelectedItem.ToString());
            int numero2 = int.Parse(this.comboBox2.SelectedItem.ToString());
            int resultado = numero * numero2;

            MessageBox.Show(resultado.ToString());
        }
    }
}
