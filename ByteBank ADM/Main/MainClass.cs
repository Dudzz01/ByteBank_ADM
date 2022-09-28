using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_ADM.Funcionários;
using ByteBank_ADM.Utilitario;
using ByteBank_ADM.SistemaInternoByteBank;
using ByteBank_ADM.ParceiriaByteBank;


namespace ByteBank_ADM.Main
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            GerenciamentoDeBonificacao gerenciamentoDeBonificacao = new GerenciamentoDeBonificacao();
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor = new Diretor("Amanda", "13026327", "123", "Dudu");
            Diretor diretor2 = new Diretor("Eduardo", "2123324", "789", "Amanda");
            ParceiroComercial parceiro1 = new ParceiroComercial("Joel", "200");

            //Defina os metodos dos objetos que quiser abaixo




        }
    }

}
