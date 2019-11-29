using ApplicationTeste.Global;
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
    public partial class MenuConsultar : Form
    {
        private MenuPrincipal menuprinc = new MenuPrincipal();
        public MenuConsultar(MenuPrincipal formmenu)
        {
            menuprinc = formmenu;
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            //if (DadosGlobais.Permissao.Equals(1))
            //{
                ConsultarCliente conscli = new ConsultarCliente();
                conscli.TopLevel = false;
                conscli.FormBorderStyle = FormBorderStyle.None;
                menuprinc.Painelprincipal.Controls.Clear();
                menuprinc.Painelprincipal.Controls.Add(conscli);
                menuprinc.Painelprincipal.Visible = true;
                conscli.Show();
            //}
            /*else
            {
                MessageBox.Show("Você não possui permissão de acesso!");
            }*/
        }

        private void MenuConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
