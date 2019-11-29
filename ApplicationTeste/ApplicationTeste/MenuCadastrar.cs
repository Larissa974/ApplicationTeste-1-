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
    public partial class MenuCadastrar : Form
    {
        private MenuPrincipal menup = new MenuPrincipal();
        public MenuCadastrar(MenuPrincipal form0)
        {
            menup = form0;
            InitializeComponent();
        }

        private void MenuCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            CadastrarAbastecimento cadab = new CadastrarAbastecimento();
            cadab.TopLevel = false;
            cadab.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadab);
            menup.Painelprincipal.Visible = true;
            cadab.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadcli = new CadastrarCliente();
            cadcli.TopLevel = false;
            cadcli.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadcli);
            menup.Painelprincipal.Visible = true;
            cadcli.Show();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            CadastrarMotorista cadmot = new CadastrarMotorista();
            cadmot.TopLevel = false;
            cadmot.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadmot);
            menup.Painelprincipal.Visible = true;
            cadmot.Show();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            CadastrarAluguel cadal = new CadastrarAluguel();
            cadal.TopLevel = false;
            cadal.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadal);
            menup.Painelprincipal.Visible = true;
            cadal.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor cadforn = new CadastrarFornecedor();
            cadforn.TopLevel = false;
            cadforn.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadforn);
            menup.Painelprincipal.Visible = true;
            cadforn.Show();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            CadastrarViagem cadviag = new CadastrarViagem();
            cadviag.TopLevel = false;
            cadviag.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadviag);
            menup.Painelprincipal.Visible = true;
            cadviag.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            CadastrarManutencao cadmanut = new  CadastrarManutencao();
            cadmanut.TopLevel = false;
            cadmanut.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadmanut);
            menup.Painelprincipal.Visible = true;
            cadmanut.Show();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadprod = new CadastrarProduto();
            cadprod.TopLevel = false;
            cadprod.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadprod);
            menup.Painelprincipal.Visible = true;
            cadprod.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario cadfunc = new CadastrarFuncionario();
            cadfunc.TopLevel = false;
            cadfunc.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadfunc);
            menup.Painelprincipal.Visible = true;
            cadfunc.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnaviso_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadusu = new CadastrarUsuario();
            cadusu.TopLevel = false;
            cadusu.FormBorderStyle = FormBorderStyle.None;
            menup.Painelprincipal.Controls.Clear();
            menup.Painelprincipal.Controls.Add(cadusu);
            menup.Painelprincipal.Visible = true;
            cadusu.Show();
        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
