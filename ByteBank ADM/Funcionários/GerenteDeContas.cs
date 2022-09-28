using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SistemaInternoByteBank;
namespace ByteBank_ADM.Funcionários
{
    public class GerenteDeContas: FuncionárioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf, string senha, string login): base(nome,cpf,4000,senha,login)
        {
            
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override double GetPremioSemestral()
        {
            return Salario * 0.10;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
