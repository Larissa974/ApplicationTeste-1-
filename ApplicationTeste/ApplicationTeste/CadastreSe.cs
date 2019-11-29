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
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

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
            if (txbSenha.Text.Equals(txbConfSenha.Text))
            {
                Usuario user = new Usuario();
                user.Email = txbEmail.Text;
                user.Login = txbUsuario.Text;
                user.Senha = txbSenha.Text;
                
                LoginService service = new LoginService();

                if (!service.SalvarUsuario(user))
                {
                    MessageBox.Show("Erro ao cadastrar dados");
                }

                else
                {
                    this.Hide();
                    Login lg = new Login();
                    lg.Show();
                }
                

            }
            else
            {
                MessageBox.Show("Senhas diferentes!");
            }

            

        }

        private void txbUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
