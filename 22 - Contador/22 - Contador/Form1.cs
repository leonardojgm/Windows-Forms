using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22___Contador
{
    public partial class Form1 : Form
    {
        private int totalDeSegundos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;

            for (int i = 0; i < 60; i++ )
            {
                this.comboBox1.Items.Add(i.ToString("00"));
                this.comboBox2.Items.Add(i.ToString("00"));
            }

            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;

            int minutos = int.Parse(this.comboBox1.SelectedIndex.ToString());
            int segundos = int.Parse(this.comboBox2.SelectedIndex.ToString());

            totalDeSegundos = (minutos * 60) + segundos;

            this.timer1.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.timer1.Enabled = false;
            this.label1.Text = "59:59";
            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;

            totalDeSegundos = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            if(totalDeSegundos > 0)
            {
                int minutos = totalDeSegundos / 60;
                int segundos = totalDeSegundos - (minutos * 60);

                this.label1.Text = minutos.ToString("00") + ":" + segundos.ToString("00");

                totalDeSegundos--;
            }
            else
            {
                this.timer1.Enabled = false;
                MessageBox.Show("O contador acabou!");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.comboBox1.Text.ToString() + ":" + this.comboBox2.Text.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.label1.Text = this.comboBox1.Text.ToString() + ":" + this.comboBox2.Text.ToString();
        }
    }
}
