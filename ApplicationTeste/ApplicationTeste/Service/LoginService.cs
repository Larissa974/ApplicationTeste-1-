using ApplicationTeste.DAO;
using ApplicationTeste.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTeste.Service
{
    class LoginService
    {
        private LoginDaoComandos dao = new LoginDaoComandos();
        public Boolean SalvarUsuario(Usuario usuario)
        {
            try
            {
                dao.cadastrar(usuario.Login, usuario.Email, usuario.Senha);
            }
            catch (Exception erro)
            {
                System.Diagnostics.Debug.WriteLine(erro);
                return false;
            }
            return true;
        }

        public Boolean Autenticar(Usuario usuario)
        {
            try
            {
                if (dao.verificarLogin(usuario.Login, usuario.Senha)) {
                    return true;
                }

                else
                {
                    return false;
                }
             
            }

            catch (Exception erro)
            {
                System.Diagnostics.Debug.WriteLine(erro);
                return false;
            }

            //return true;
        }
    }
}
