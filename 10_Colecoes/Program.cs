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
            Dictionary<int, String> dicNomes = new Dictionary<int, String>();
            dicNomes.Add(1, "Gustavo");
            dicNomes.Add(2, "paulo");
            dicNomes.Add(3, "maycon");

            Console.WriteLine("impressão dos dicNomes");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($"- {dicNomes[i]}");
            }
            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(maycon.id, maycon);
            dicAlunos.Add(paulo.id, paulo);

            Console.WriteLine("impressão dos dicAlunos");
           // for (int i = 1; i <= dicAlunos.Count; i++)
        //    {
         //       dicAlunos[i].ImprimirAluno();
         //   }
         foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }

         Queue<string> filaNomes = new Queue<string>();
            filaNomes.Enqueue("Gustavo");
            filaNomes.Enqueue("paulo");
            filaNomes.Enqueue("maycon");

            Console.WriteLine("Impressao dos filaNomes");
            Console.WriteLine($" 1º) {filaNomes.Dequeue()}");

            foreach (string nome in filaNomes)
            {
                Console.WriteLine($"- {nome}");
            }

            Stack<string> stackNomes = new Stack<string>();
            stackNomes.Push("gustavo");
            stackNomes.Push("paulo");
            stackNomes.Push("maycon");

            Console.WriteLine($"Impressão dos stackNomes");
            Console.WriteLine($" 1º ){stackNomes.Pop()}");

            foreach (string nome in stackNomes)
            {
                Console.WriteLine($"- {nome}");
            }

            HashSet<string> setNomes = new HashSet<string>();
            setNomes.Add("gustavo");
            setNomes.Add("paulo");
            setNomes.Add("maycon");
            setNomes.Add("gustavo");
            setNomes.Add("paulo");
            setNomes.Add("maycon");


            Console.WriteLine("impressao dos setNomes");
            foreach (string nome in setNomes)
            {
                Console.WriteLine($"- {nome}");
            }



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
//concolusao 
//cole~ção sao mais flexiveis que  
//cada tipo setrve a uma necessidade
//list > lista ordena com dúplicadas 
//dictionary > chave e valor
// queue > fila FIFO
//Stack > pilha FIFO 