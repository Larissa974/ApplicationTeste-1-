using ApplicationTeste.Global;
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
    public partial class ConfiguracaodoSistema : Form
    {
        string opcaoTema = DadosGlobais.temaTexto;
        public ConfiguracaodoSistema()
        {
            InitializeComponent();
        }

        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alteracoes = 0;

            Configuracao config = new Configuracao();
            

            if (this.comboBox1.SelectedItem != DadosGlobais.idiomaTexto && this.comboBox1.SelectedItem != null)
            {
                config.AlterarConfigIdioma(comboBox1.SelectedItem.ToString());
                alteracoes = alteracoes + 1;
            }
            
            if (this.comboBox2.SelectedItem != DadosGlobais.temaTexto && this.comboBox2.SelectedItem != null)
            {
                config.AlterarConfigTema(comboBox2.SelectedItem.ToString());
                alteracoes = alteracoes + 1;
            }
            
            
            if(alteracoes != 0)
            {
                MessageBox.Show("O programa será reinicializado para que as alterações sejam efetivadas!");
                Application.Restart();
            }

            else
            {
                MessageBox.Show("Nenhuma alteração realizada.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configuracao config = new Configuracao();
            config.GravarConfigInicial();
            MessageBox.Show("O programa será reinicializado para que as alterações sejam efetivadas!");
            Application.Restart();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
    
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
