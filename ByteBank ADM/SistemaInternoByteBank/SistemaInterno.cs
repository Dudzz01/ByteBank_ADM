using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionários;

namespace ByteBank_ADM.SistemaInternoByteBank
{
    public class SistemaInterno
    {

        public bool LoginSistema(IAutenticacao funcionário, string login, string senha)
        {
            if(funcionário.AutenticarLogin(login) == true && funcionário.AutenticarSenha(senha) == true)
            {
                Console.WriteLine("Bem vindo ao Sistema Interno do Banco ByteBank");
                return true;
                
            }
            Console.WriteLine("Acesso negado");
            return false;
        }
    }
}
