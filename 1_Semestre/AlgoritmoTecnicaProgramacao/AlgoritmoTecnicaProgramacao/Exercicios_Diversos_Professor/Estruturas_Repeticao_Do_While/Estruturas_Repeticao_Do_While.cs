using System;
using System.Globalization;

namespace AlgoritmoTecnicaProgramacao.Exercicios_Diversos_Professor
{
    public class Estruturas_Repeticao_Do_While
    {
        /*
         * //Estruturas repeticao do_while

        1) Escreva um programa que calcule a seguinte série:S = 1/1 + 3/2 + 5/3 + 7/4 + ... + 99/50
        
        2) Faça um programa que leia 10 valores quaisquer, um de cada vez, e conta quantos destes valores são negativos.
        
        3) Ler o número de alunos existentes em uma turma, ler as 3 notas destes alunos e calcular a média aritmética destas notas.
        
        4) Faça um algoritmo para ler uma quantidade indeterminada de valores inteiros. 
           Para cada valor fornecido escrever uma mensagem que indica se cada valor fornecido é PAR ou ÍMPAR. 
           O algoritmo será encerrado imediatamente após a leitura de um valor NULO (zero) ou NEGATIVO.

         */
        public static void EstruturasRepeticao()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Estruturas Repeticão DO_WHILE<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.WriteLine("\n\n1 - Calcular Um Série de Numeros\n\n2 - Contar Números Negativos Digitados" +
                "\n\n3 - Média das Notas dos Alunos\n\n4 - Verificar Números Pares Ou Impáres");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite qual exercício deseja  executar: ");


            int operacao;
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    CalculaSerie();
                    break;
                case 2:
                    VerificaNumerosNegativos();
                    break;
                case 3:
                    MediaNotasAlunos();
                    break;
                case 4:
                    VerificaNumeroParImpar();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        public static void CalculaSerie()
        {
            double serie, numeroA = 1, numeroB = 1;

            do
            {
                serie = numeroA / numeroB;
                numeroA = numeroA + 2;
                numeroB++;

                Console.WriteLine("\nserie = " + numeroA + "/" + numeroB);

                //Console.WriteLine("\nNumero A: " + numeroA);
                //Console.WriteLine("\nNumero B: " + numeroB);

            } while (numeroA < 99);

            Console.WriteLine("\n\nValor Final Série: " + serie.ToString("F"));
            Console.ReadLine();
        }

        public static void VerificaNumerosNegativos()
        {
            int intervalo = 0, quantidadeNumerosNegativos = 0, serie;
            Random randNum = new Random();

            do
            {
                serie = randNum.Next(-5, 5);

                if(serie < 0)
                {
                    quantidadeNumerosNegativos = quantidadeNumerosNegativos + 1;
                }

                Console.WriteLine("\nNumero Informado = " + serie);
                intervalo++;

            } while (intervalo < 10);

            Console.WriteLine("\n\nO total de números negativos digitados é de: " + quantidadeNumerosNegativos);
            Console.ReadLine();
        }

        public static void MediaNotasAlunos()
        {

        }

        public static void VerificaNumeroParImpar()
        {

        }
    }
}
