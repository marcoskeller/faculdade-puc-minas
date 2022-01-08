using System;


namespace AlgoritmoTecnicaProgramacao.Dia_17_11_2021
{
    public class OperacoesBasicasComVetor
    {
        public static double mediaVetor = 0;

        public static void TrabalhandoVetores()
        {
            /*
             * Escreva um programa em C# para:
                a) ler e armazenar 10 números inteiros positivos;
                b) calcular a média aritmética dos números lidos;
                c) verificar quantos números são maiores que a média e em que posição da sequência estão.

            
             */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Operações com Vetores<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int tamanhoVetor, somatorioVetor = 0;
            //double mediaVetor = 0;
            int[] vetorNumeros;

            Console.Write("\n\nInforme qual será o tamanho do vetor:");
            tamanhoVetor = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            vetorNumeros = ElementosVetor(tamanhoVetor);
            somatorioVetor = SomaElementosVetor(vetorNumeros);
            mediaVetor = (double)somatorioVetor / vetorNumeros.Length;

            Console.WriteLine("\n\nSomatório dos Números do Vetor é: " + somatorioVetor);
            Console.WriteLine("\nMédia dos Números do Vetor é: " + mediaVetor);
            Console.WriteLine("\n");

            NumerosMaioresMediaPosicao(vetorNumeros);
            Console.WriteLine("\n\n\n\n");

        }

        static int[] ElementosVetor(int quantidadeNumeros)
        {
            int[] vetorPosicoes = new int[quantidadeNumeros];

            for(int i = 0; i < vetorPosicoes.Length; i++)
            {
                Console.Write((i + 1) + "º = ");
                vetorPosicoes[i] = int.Parse(Console.ReadLine());
            }

            return (vetorPosicoes);
        }

        static int SomaElementosVetor(int[] somatorioVetor)
        {
            int soma = 0;
          
            for(int i = 0; i < somatorioVetor.Length; i++)
            {
                soma = soma + somatorioVetor[i];
            }

            return (soma);
        }

        static void NumerosMaioresMediaPosicao(int[] vetorNumeros)
        {
            int quantidadeNumerosMaioresMedia = 0;
            for(int i = 0; i < vetorNumeros.Length; i++)
            {
                if(vetorNumeros[i] > mediaVetor)
                {
                    Console.WriteLine(vetorNumeros[i] + " é Maior que a média " + mediaVetor + " e está na: " + (i+1) + "º Posição");
                    quantidadeNumerosMaioresMedia++;
                }
            }

            Console.WriteLine("\n\nQuantidade de números maiores que a média é: " + quantidadeNumerosMaioresMedia);
        }
    }
}
