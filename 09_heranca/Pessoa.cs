using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_heranca
{
    internal  abstract class Pessoa
    {
        public string Nome;
        public int telefone;

        public abstract string GetDocumento();
        
        public void Imprimir()
        {
            Console.WriteLine($"\nLISTA DE PESSOA\n\nnome:{this.Nome} Documento:{this.GetDocumento()} Telefone:{this.telefone}");
        }

    }
}
