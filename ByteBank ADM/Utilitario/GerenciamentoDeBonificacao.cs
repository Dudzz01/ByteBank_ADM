using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionários;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciamentoDeBonificacao 
    {
        public double TotalBonificacao { get; private set; }
        public double TotalPremiacao { get; private set; }

        public double Registrar(Funcionário funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
            return TotalBonificacao;
        }

        public double RegistrarPremio(Funcionário funcionário)
        {
            TotalPremiacao += funcionário.GetPremioSemestral();
            return TotalPremiacao;
        }

       
        
    }
}
