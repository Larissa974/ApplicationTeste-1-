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
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuCadastrar menucad = new MenuCadastrar(this);
            menucad.TopLevel = false;
            menucad.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Clear();
            Painelprincipal.Controls.Add(menucad);
            Painelprincipal.Visible = true;
            menucad.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuConsultar menucon = new MenuConsultar(this);
            menucon.TopLevel = false;
            menucon.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Clear();
            Painelprincipal.Controls.Add(menucon);
            Painelprincipal.Visible = true;
            menucon.Show();
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
            Painelprincipal.Controls.Clear();
            PaginaInicial pagini = new PaginaInicial();
            pagini.TopLevel = false;
            pagini.FormBorderStyle = FormBorderStyle.None;
            Painelprincipal.Controls.Add(pagini);
            pagini.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
