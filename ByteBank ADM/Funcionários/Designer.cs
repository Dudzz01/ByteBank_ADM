using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionários
{
    public class Designer:Funcionário
    {
        public Designer(string nome, string cpf): base(nome,cpf,3000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override double GetPremioSemestral()
        {
            return Salario * 0.10;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

    }
}
