using ApplicationTeste.Modelo;
using ApplicationTeste.Service;
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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCadastrarSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginService service = new LoginService();
            Usuario usuario = new Usuario();
            usuario.Login = txbUsuario.Text;
            usuario.Senha = txbSenha.Text;

            if (!service.Autenticar(usuario))
            {
                MessageBox.Show("Erro ao logar!");
            }

            else
            {
                this.Hide();
                MenuPrincipal bv = new MenuPrincipal();
                bv.Show();
            }

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxbUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxbSenha_OnValueChanged(object sender, EventArgs e)
        {
       
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
