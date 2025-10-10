using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            

            try
            {

                Console.Write("Digite o caminho completo do arquivo: ");
                string caminho = Console.ReadLine();
                
                string conteudo = File.ReadAllText(caminho);

                Console.WriteLine("\n Conteúdo do arquivo:");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }

            Console.WriteLine("\nPrograma finalizado!");
        }
    }
}
