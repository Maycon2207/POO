using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> filaNomes = new Queue<String>();

            Console.WriteLine("=== Simulação de Fila de Atendimento ===");
            

            for (int i = 1; i <= 5; i++)
            {
                string nome;
                do
                { 

                    Console.WriteLine($"Digite o nome da {i}ª pessoa: ");
                    nome = Console.ReadLine();

                    

                    if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                    {
                        Console.WriteLine("❌ O nome deve conter no mínimo 3 caracteres. Tente novamente.");
                    }

                } while (string.IsNullOrWhiteSpace(nome) || nome.Length < 3);

                filaNomes.Enqueue(nome);


            }

            Console.WriteLine("\n--- Atendimento ---");
            for (int i = 1; i <= 3; i++)
            {
                if (filaNomes.Count > 0)
                {
                    string atendido = filaNomes.Dequeue();
                    Console.WriteLine($"Atendendo {i}ª pessoa: {atendido}");
                }
               
            }

            Console.WriteLine("\n--- Ainda aguardando na fila ---");

            
            if(filaNomes.Count > 0)
            {
                foreach (var nome in filaNomes)
                {
                    Console.WriteLine(nome);
                }
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }

        }
    }
}
