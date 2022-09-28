using ByteBank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank_ADM.SistemaInternoByteBank
{
    public abstract class FuncionárioAutenticavel : Funcionário, IAutenticacao
    {
        public string Senha { get; protected set; }
        public string Login { get; protected set; }

        public FuncionárioAutenticavel(string nome, string cpf, double salario, string senha, string login) : base(nome, cpf, salario)
        {
            Senha = senha;
            Login = login;
            
        }

        public virtual bool AutenticarSenha(string senha)
        {
            return this.Senha == senha;
        }

        public virtual bool AutenticarLogin(string login)
        {
            return this.Login == login;
        }
    }
}
