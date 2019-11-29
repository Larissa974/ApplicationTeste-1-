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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            lbldata.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void Painelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Painelprincipal.Controls.Clear();
            PaginaInicial pagini = new PaginaInicial();
            pagini.TopLevel = false;
            pagini.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Add(pagini);
            pagini.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Painelprincipal.Controls.Clear();
            PaginaInicial pagini = new PaginaInicial();
            pagini.TopLevel = false;
            pagini.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Add(pagini);
            pagini.Show();
        }

        private void Pnlmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MenuCadastrar menucad = new MenuCadastrar(this);
            menucad.TopLevel = false;
            menucad.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Clear();
            Painelprincipal.Controls.Add(menucad);
            Painelprincipal.Visible = true;
            menucad.Show();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            MenuConsultar menucon = new MenuConsultar(this);
            menucon.TopLevel = false;
            menucon.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Clear();
            Painelprincipal.Controls.Add(menucon);
            Painelprincipal.Visible = true;
            menucon.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Painelprincipal.Controls.Clear();
            ConfiguracaodoSistema confsist = new ConfiguracaodoSistema();
            confsist.TopLevel = false;
            confsist.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Add(confsist);
            confsist.Show();
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Painelprincipal.Controls.Clear();
            PerfilUsuario perfilusu = new PerfilUsuario();
            perfilusu.TopLevel = false;
            perfilusu.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Add(perfilusu);
            perfilusu.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar seção?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {

            }
        }
    }
}
