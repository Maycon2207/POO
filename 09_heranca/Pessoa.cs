using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_heranca
{
    internal  abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public int telefone;

        public abstract string GetDocumento();
        
        public void Imprimir()
        {
            Console.WriteLine($"\nLISTA DE PESSOA\n\nnome:{this.Nome} Documento:{this.GetDocumento()} Telefone:{this.telefone}");
        }
        public override string ToString()
        {
            return $"<toString()>nome:{this.Nome} Documento:{this.GetDocumento()} Telefone:{this.telefone}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null /*|| this.GetType() != obj.GetType()*/)
            
                return false;
            //Cast=> conversao de objeto
            //((pessoa)obj).Id => converte obj que e do tipo object para o tipo pessoa
            return this.Id == ((Pessoa)obj).Id;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();  
        }
    }
}
