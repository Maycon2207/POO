using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ProproedadesAposNet9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Conta conta = new Conta("16445-7");

            conta.setNome("Osvaldo Fernando");

            conta.Depositar(1000.00m);
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]- Depositar, [S]- Sacar ou [E]- Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo():c2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para Sair");
                }
            }
        }
    }

    public class Conta
    {
        private string numero;
        private string nome;
        private decimal saldo;

        public Conta(string numero)
        {
            this.numero = numero;
        }

        // Métodos acessores
        public decimal getSaldo()
        {
            return saldo;
        }

        public string getNumero()
        {
            return numero;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Saque inválido! Verifique o valor e o saldo disponível.");
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }
    }
}