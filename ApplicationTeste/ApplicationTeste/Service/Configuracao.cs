using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ApplicationTeste.Global;
using System.Windows.Forms;

namespace ApplicationTeste.Service
{
    class Configuracao
    {
        public Boolean GravarConfigInicial()
        {
            try
            {
                StreamWriter ConfigInicial = new StreamWriter("FileConfig.txt");
                ConfigInicial.WriteLine("Português");
                ConfigInicial.WriteLine("Azul");
                ConfigInicial.Close();
                DadosGlobais.idiomaTexto = "Português";
                DadosGlobais.idioma = 0;
                DadosGlobais.temaTexto = "Azul";
                DadosGlobais.tema = 0;
                ConfigInicial.Close();

                if (!AtribuirConfig())
                {
                    MessageBox.Show("Configuração atribuida gravada. Erro na atribuição!");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao gravar configurãção inicial!");
                return false;
            }

            return true;
        }

        public Boolean AlterarConfigIdioma(string idiomaTexto)
        {
            try
            {
                StreamWriter ConfigInicial = new StreamWriter("FileConfig.txt");
                ConfigInicial.WriteLine(idiomaTexto);
                ConfigInicial.WriteLine(DadosGlobais.temaTexto);
                ConfigInicial.Close();
                AtribuirConfig();
            }
            catch
            {
                MessageBox.Show("Erro ao alterar configurãção!");
                return false;
            }
            
            return true;
        }

        public Boolean AlterarConfigTema(string temaTexto)
        {
            try
            {
                StreamWriter ConfigInicial = new StreamWriter("FileConfig.txt");
                ConfigInicial.WriteLine(DadosGlobais.idiomaTexto);
                ConfigInicial.WriteLine(temaTexto);
                ConfigInicial.Close();
                AtribuirConfig();
            }
            catch
            {
                MessageBox.Show("Erro ao alterar configurãção!");
                return false;
            }

            return true;
        }

        public Boolean AtribuirConfig()
        {
            try
            {
                StreamReader ConfigInicial = new StreamReader("FileConfig.txt");

                switch (ConfigInicial.ReadLine())
                {
                    case "Português":
                        DadosGlobais.idiomaTexto = "Português";
                        DadosGlobais.idioma = 0;
                        break;

                    case "Inglês":
                        DadosGlobais.idiomaTexto = "Inglês";
                        DadosGlobais.idioma = 1;
                        break;
                }

                switch (ConfigInicial.ReadLine())
                {
                    case "Azul":
                        DadosGlobais.temaTexto = "Azul";
                        DadosGlobais.tema = 0;
                        break;

                    case "Amarelo":
                        DadosGlobais.temaTexto = "Amarelo";
                        DadosGlobais.tema = 1;
                        break;
                        
                }

                ConfigInicial.Close();
            }

            catch
            {
                if (!GravarConfigInicial())
                {
                    return false;
                }
            }

            return true;
        }

        public string[] VerificaConfig()
        {
            string[] configuracao = {"",""};

            try
            {
                configuracao[0] = DadosGlobais.idiomaTexto;
                configuracao[1] = DadosGlobais.temaTexto;
            }

            catch
            {
                configuracao[0] = null;
                configuracao[1] = null;
            }

            return configuracao;

        }

    }
}
