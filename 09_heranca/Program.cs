using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nao e possivel instanciar uma classe abstrata
            //pessoa obj = new pessoa();
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.Cpf = "123.456.789-00";
            pessoaFisica.telefone = 123456789;
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.Nome = "Empresa LTDA";
            pessoaJuridica.Cnpj = "12.345.678/0001-00";
            pessoaJuridica.telefone = 987654321;
            pessoaJuridica.Imprimir();
        }
    }
}
