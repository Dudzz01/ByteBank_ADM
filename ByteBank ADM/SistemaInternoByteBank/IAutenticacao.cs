using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInternoByteBank
{
    public interface IAutenticacao
    {
        
        public bool AutenticarSenha(string senha);
        public bool AutenticarLogin(string login);

        
        
            
        
    }
}
