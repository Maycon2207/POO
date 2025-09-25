using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> nomes = new List<string>();
            nomes.Add("maycon");
            nomes.Add("paulo");

            List<Aluno> alunos = new List<Aluno>();
            Aluno maycon = new Aluno { id = 1, Nome = "maycon" };
            AlunoEspecial paulo = new AlunoEspecial { id = 2, Nome = "paulo", Deficiencia = "visual" };
            alunos.Add(maycon);
            alunos.Add (paulo);

            alunos.Add( new Aluno { id = 3, Nome = "gustavo"});
            nomes.Add(maycon.Nome);

            Console.WriteLine("impressao dos nomes");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");

            }
            Console.WriteLine("impressao do aluno");
            foreach (Aluno aluno in alunos)
            {
                 //Console.WriteLine($" - Nome: {aluno.Nome } ID {aluno.id} ");
                aluno.ImprimirAluno();
            }
;



        }
    }
    class Aluno
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public double[] Notas { get; set; }

        public virtual void ImprimirAluno()
        {
            Console.WriteLine($" ID: {this.id} Nome:{this.Nome} ");
        }

    }


    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        public override void ImprimirAluno()
        {
         Console.WriteLine($" ID: {this.id} Nome:{this.Nome} - {this.Deficiencia} ");
        }



    }
}
