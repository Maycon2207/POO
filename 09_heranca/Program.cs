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

            Pessoa[] pessoas = new Pessoa[2];


            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Id = 1;
            pessoaFisica.Nome = "Geraldo";
            pessoaFisica.Cpf = "123.456.789-00";
            pessoaFisica.telefone = 123456789;
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Empresa LTDA";
            pessoaJuridica.Cnpj = "12.345.678/0001-00";
            pessoaJuridica.telefone = 987654321;
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica))
                Console.WriteLine("É a mesma pessoa");
            else
                Console.WriteLine("Não é a mesma pessoa");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
           
        }

    }
}
