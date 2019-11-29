using ApplicationTeste.Global;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTeste.DAO
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;

        public bool verificarLogin(String usuario, String senha)
        {
            tem = false;
            //comando sql para verificar se tem no banco
            cmd.CommandText = "select * from TB_LOGIN where TB_LOGIN_USUARIO = @usuario and TB_LOGIN_SENHA = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())//se for encontrado
                {
                    tem = true;
                    DadosGlobais.email = dr["TB_LOGIN_EMAIL"].ToString();
                    DadosGlobais.login = dr["TB_LOGIN_USUARIO"].ToString();

                    /*
                     * DadosGlobais.idioma = dr["TB_LOGIN_IDIOMA"].ToString();

                    switch (DadosGlobais.idioma)
                    {
                        case "0":
                            DadosGlobais.idiomaTexto = "Português";
                            break;

                        case "1":
                            DadosGlobais.idiomaTexto = "Inglês";
                            break;

                    }
                    */

                    String nivelPermissao = dr["TB_LOGIN_PERMISSAO"].ToString();
                    switch (nivelPermissao)
                    {
                        case "0":
                            DadosGlobais.nivelPermissao = "Padrão1";
                            DadosGlobais.Permissao = 0;
                            break;

                        case "1":
                            DadosGlobais.nivelPermissao = "Padrão2";
                            DadosGlobais.Permissao = 1;
                            break;

                        case "2":
                            DadosGlobais.nivelPermissao = "Padrão3";
                            DadosGlobais.Permissao = 2;
                            break;
                    }
                    
                }

                con.desconectar();
                dr.Close();
            }

            catch(MySqlException)
            {
                this.mensagem = "Erro de conexão com o Banco de dados.";
            }

            return tem;
        }

        public String cadastrar(String usuario, String email, String senha)
        {
            tem = false;
            //comandos para inserir
                cmd.CommandText = "insert into TB_LOGIN (TB_LOGIN_USUARIO,TB_LOGIN_EMAIL,TB_LOGIN_SENHA) values (@u,@e,@s);";
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }

                catch (MySqlException erro)
                {
                    this.mensagem = "Erro de conexao com Banco de dados."+erro;
                }
 
            return mensagem;
        }
    }
}
