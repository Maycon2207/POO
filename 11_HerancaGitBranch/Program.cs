using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HerancaGitBranch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bradesco bancoBradesco = new Bradesco { NomeBanco = "Banco Bradesco S.A." };
            bancoBradesco.imprimirDados();

            PicPay bancoPicPay = new PicPay { NomeBanco = "PicPay"};
            bancoPicPay.imprimirDados();

            BancoDoBrasil bancoDoBrasil = new BancoDoBrasil { NomeBanco = "Banco do Brasil S.A." };
            bancoDoBrasil.imprimirDados();
        
            Carrefour bancoCarrefour = new Carrefour { NomeBanco = "Banco Carrefour S.A." };
            bancoCarrefour.imprimirDados();

            Original bancoOriginal = new Original { NomeBanco = "Banco Original S.A." };
            bancoOriginal.imprimirDados();

            BancoBrasil bancoBrasil = new BancoBrasil { NomeBanco = "Banco Brasil S.A." };
            bancoBrasil.imprimirDados();




            Next bancoNext = new Next { NomeBanco = "Banco Next S.A." };
            bancoNext.imprimirDados();

            bancoPAN bancoPAN = new bancoPAN { NomeBanco = "Banco PAN S.A." };
            bancoPAN.imprimirDados();

            Nubank nubank = new Nubank { NomeBanco = "NU Pagamentos S.A. – Nubank" };
            nubank.imprimirDados();



            Santander bancoSantander = new Santander { NomeBanco = "Banco Santander (Brasil) S.A." };
            bancoSantander.imprimirDados();


            Itau bancoItau = new Itau { NomeBanco = "Itaú S.A" };
            bancoItau.imprimirDados();

        }
    }
}
