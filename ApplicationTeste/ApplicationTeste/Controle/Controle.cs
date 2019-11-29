using ApplicationTeste.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTeste.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem="";

        public bool acessar(String usuario, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(usuario, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String usuario, String email, String senha, String confsenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this. mensagem = loginDao.cadastrar(usuario, email, senha);
            if (loginDao.tem)//a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
