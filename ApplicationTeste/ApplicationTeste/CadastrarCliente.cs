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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtraz.Clear();
            txtempre.Clear();
            txtinscri.Clear();
            txtmun.Clear();
            txtemail.Clear();
            txtende.Clear();
            txtnum.Clear();
            txtcompl.Clear();
            txtbairro.Clear();
            txtcida.Clear();
            msktele.Clear();
            maskcnpj.Clear();
            mskcel.Clear();
            
        }

        private void Cmbuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbuf.Items.Add("SP");
        }
    }
}
