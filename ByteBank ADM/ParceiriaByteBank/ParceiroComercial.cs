using ByteBank_ADM.SistemaInternoByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ParceiriaByteBank
{
    public class ParceiroComercial : IAutenticacao
    {
        public string Senha { get; protected set; }
        public string Login { get; protected set; }

        public ParceiroComercial(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool AutenticarLogin(string login)
        {
            return this.Login == login;
        }

        public bool AutenticarSenha(string senha)
        {
            return this.Senha == senha;
        }
    }
}
