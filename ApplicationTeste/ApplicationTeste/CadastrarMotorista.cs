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
    public partial class CadastrarMotorista : Form
    {
        public CadastrarMotorista()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            msk1.Clear();
            msk2.Clear();
            msk3.Clear();
            msk4.Clear();
            msk5.Clear();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void msk1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
