using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _19___Bloco_de_Notas_Simples
{
    public partial class Form1 : Form
    {
        private OpenFileDialog abrirDialogo;
        private SaveFileDialog salvarDialogo;
        private FontDialog fonteDialogo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fonteDialogo = new FontDialog();
        }

        private void CriarNovo()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.richTextBox1.Text) && this.Text == "Sem título")
                    MessageBox.Show("Arquivo não está salvo!");
                else
                {
                    this.Text ="Sem título";
                    this.richTextBox1.Text = string.Empty;
                }
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void AbrirArquivo()
        {
            try
            {
                abrirDialogo = new OpenFileDialog();
                if (abrirDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(abrirDialogo.FileName);
                    this.Text = abrirDialogo.FileName;
                }
            }
            catch
            {

            }
            finally
            {
                abrirDialogo = null;
            }
        }

        private void SalvarArquivo()
        {
            try
            {
                salvarDialogo = new SaveFileDialog();
                salvarDialogo.Filter = "Arquivo de Texto (*.txt) | *.txt";
                if (salvarDialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarDialogo.FileName, this.richTextBox1.Text);
                    this.Text = salvarDialogo.FileName;
                }
            }
            catch
            {

            }
            finally
            {
                salvarDialogo = null;
            }
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovo();
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fonteDialogo = new FontDialog();
                if (fonteDialogo.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = fonteDialogo.Font;
                }
            }
            catch
            {

            }
            finally
            {
                fonteDialogo = null;
            }
        }
    }
}
