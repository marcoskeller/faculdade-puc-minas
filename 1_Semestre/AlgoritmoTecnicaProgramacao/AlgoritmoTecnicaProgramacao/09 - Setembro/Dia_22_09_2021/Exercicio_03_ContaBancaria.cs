using System;
using System.Threading.Tasks;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class  Exercicio_03_ContaBancaria
    {
        /*
         * 3) Um terminal de caixa eletrônico de um banco disponibiliza para os clientes as seguintes opções:
                1) Saque
                2) Depósito
                3) Pagamento de Conta
                4) Transferência
                Faça um algoritmo em C# que:
                a) leia o saldo atual da conta corrente do cliente;
                b) leia a operação desejada pelo usuário, conforme a numeração acima;
                c) leia o valor da operação a ser realizada;
                d) calcule e escreva o saldo final da conta.
         */
        static double saque, deposito, pagamentoConta, transferencia, saldoInicial, saldoAtualizado, saldoAtual;

        public static void ContaBancaria()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Conta Bancária<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.WriteLine("\n\n1 - Saque\n2 - Depósito\n3 - Pagamento de Conta\n4 - Transferência");
          
           
            int operacaoBancaria;
            Console.Write("\n\nDigite a operação desejada: ");
            operacaoBancaria = int.Parse(Console.ReadLine());

            switch (operacaoBancaria)
            {
                case 1:
                    Saque();
                    break;
                case 2:
                    Deposito();
                    break;
                case 3:
                    PagamentoConta();
                    break;
                case 4:
                    Transferencia();
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }
        }

        public static void Saque()
        {
            Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
            saldoAtual = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor que deseja sacar: R$");
            saque = double.Parse(Console.ReadLine());

            if(saque > saldoAtual)
            {
                Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
            }
            else
            {
                saldoAtualizado = saldoAtual - saque;
                Console.WriteLine("\n\nRelatório Atualizado!");
                Console.WriteLine("\nValor a Sacar: R$" + saque);
                Console.WriteLine("\nSaldo Atualizado Após o Saque: R$" + saldoAtualizado);
            }                              
        }

        public static void Deposito()
        {
            Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
            saldoAtual = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor que deseja depositar: R$");
            deposito = double.Parse(Console.ReadLine());

            deposito = saldoAtual + deposito;

            Console.WriteLine("\n\nRelatório Atualizado!");
            Console.WriteLine("\nValor a Depositar: R$" + deposito);
            Console.WriteLine("\nSaldo Atualizado Após o Depósito: R$" + saldoAtualizado);
        }

        public static void PagamentoConta()
        {
            Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
            saldoAtual = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor da conta que irá pagar: R$");
            pagamentoConta = double.Parse(Console.ReadLine());

            if (pagamentoConta > saldoAtual)
            {
                Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
            }
            else
            {
                saldoAtualizado = saldoAtual - pagamentoConta;
                Console.WriteLine("\n\nRelatório Atualizado!");
                Console.WriteLine("\nValor da Conta a Pagar: R$" + pagamentoConta);
                Console.WriteLine("\nSaldo Atualizado Após o Pagamento da Conta: R$" + saldoAtualizado);
            }                       
        }

        public static void Transferencia()
        {
            Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
            saldoAtual = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor que irá transferir: R$");
            transferencia = double.Parse(Console.ReadLine());

            if (transferencia > saldoAtual)
            {
                Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
            }
            else
            {
                saldoAtualizado = saldoAtual - transferencia;
                Console.WriteLine("\n\nRelatório Atualizado!");
                Console.WriteLine("\nValor da Transferência a Realizar: R$" + transferencia);
                Console.WriteLine("\nSaldo Atualizado Após a Transferência do dinheiro: R$" + saldoAtualizado);
            }                    
        }
    }
}