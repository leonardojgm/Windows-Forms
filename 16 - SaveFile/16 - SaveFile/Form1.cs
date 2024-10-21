using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16___SaveFile
{
    public partial class Form1 : Form
    {
        private SaveFileDialog sfd = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK) this.pictureBox1.Image.Save(sfd.FileName);
        }
    }
}
