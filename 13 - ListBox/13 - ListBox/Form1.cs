using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++) this.listBox1.Items.Add(i.ToString());
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.listBox1.SelectedItem.ToString());
        }
    }
}
