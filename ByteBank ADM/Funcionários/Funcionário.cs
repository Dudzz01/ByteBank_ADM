using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Utilitario;
namespace ByteBank_ADM.Funcionários
{
    public abstract class Funcionário: IBonificavel
    { 
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        

        public Funcionário(string nome, string cpf, double salario) 
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public Funcionário()
        {

        }

        public bool asdjsdj()
        {
            return true;
        }


        public abstract double GetPremioSemestral();
        
        public abstract void AumentarSalario();

        public abstract double GetBonificacao(); // Implementado pela interface IBonificavel

    }
}
