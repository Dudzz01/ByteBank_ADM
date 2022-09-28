using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.SistemaInternoByteBank;
using ByteBank_ADM.Utilitario;

namespace ByteBank_ADM.Funcionários
{
    public class Diretor:FuncionárioAutenticavel  // O diretor está herdando todo o conteúdo do Funcionário (O diretor é o filho, O funcionário é o pai)
    {

        public Diretor(string nome, string cpf, string senha, string login) : base(nome, cpf, 5000, senha, login) // o metodo construtor Diretor herda o comportamento do construtor base para si mesmo( para o metodo construtor Diretor)
        {

        }

        public override double GetBonificacao()
        {

            return Salario * 0.5;

        }

        public override double GetPremioSemestral()
        {

            return Salario * 0.10;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        
    }
}
