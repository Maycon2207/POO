using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HerancaGitBranch
{
    internal abstract class Banco
    {
        public String NomeBanco {  get; set; }
        abstract public string LinhaDigitavel();
        public void imprimirDados()
        {
            Console.WriteLine($"Banco: {NomeBanco} - Linha Digitável: {LinhaDigitavel()}");
        }

    }
}
