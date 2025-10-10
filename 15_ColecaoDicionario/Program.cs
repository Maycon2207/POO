using System;
using System.Collections.Generic;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicAlunos = new Dictionary<int, string>();

            Console.WriteLine("=== Cadastro de Alunos ===");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o RA do {i}º aluno: ");
                int ra = int.Parse(Console.ReadLine());

                string nome;
                do
                {
                    Console.Write($"Digite o nome do {i}º aluno: ");
                    nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                    {
                        Console.WriteLine("❌ O nome deve ter pelo menos 3 caracteres. Tente novamente.");
                    }
                } while (string.IsNullOrWhiteSpace(nome) || nome.Length < 3);

                if (!dicAlunos.ContainsKey(ra))
                {
                    dicAlunos.Add(ra, nome); // aqui era aluno, mas o correto é nome
                }
                else
                {
                    Console.WriteLine("❌ RA já cadastrado. Tente novamente.");
                }
            }

            Console.WriteLine("\n=== Lista de Alunos Cadastrados ===");
            foreach (var aluno in dicAlunos)
            {
                Console.WriteLine($"RA: {aluno.Key} Nome: {aluno.Value}");
            }
        }
    }
}
