using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTeste
{
    public partial class CadastrarAluguel : Form
    {
        public CadastrarAluguel()
        {
            InitializeComponent();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtcida.Clear();
            txtcompl.Clear();
            txtPlaca.Clear();
            txtModelo.Clear();
            txtFabri.Clear();
            txtCusto.Clear();
            txtNome.Clear();
            txtende.Clear();
            txtNum.Clear();
            txtBai.Clear();
            textCel.Clear();
            textCNPJ.Clear();
            textTele.Clear();
        }
    }
}
