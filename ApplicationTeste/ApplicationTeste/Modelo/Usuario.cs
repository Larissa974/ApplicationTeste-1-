using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTeste.Modelo
{
    class Usuario
    {
        private int idLogin;
        private String login;
        private String email;
        private String nome;
        private String sobreNome;
        private String senha;

        public int IdLogin { get => idLogin; set => idLogin = value; }
        public string Login { get => login; set => login = value; }
        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
