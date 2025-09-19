using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_heranca
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf;

        public override string GetDocumento() //overide = sobreescrever - ele puxa do pai e usa esse quando precisar 
        {
            return this.Cpf;
        }
    }
}
