using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_12_2021
{
    public class TrabalhandoComVetores
    {
        public static void ManipulandoVetores()
        {
            /*
                Faça um programa em C# que:
	            (a) permita ao usuário informar dois números inteiros q1 e q2;
	            (b) leia q1 números inteiros e os armazene num vetor v1 e q2 números inteiros e os armazene num vetor v2;
	            (c) verifique quais são e mostre na tela os elementos do vetor v1 que são maiores que todos os elementos do vetor v2.
                (d) verifique quais são e mostre na tela os elementos do vetor v1 que são multiplos de todos os elementos do vetor v2.
            */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Trabalhando Com Vetores<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int numeroDigitado1, numeroDigitado2;
            int[] vetorPrimario, vetorSecundario;


            Console.Write("\n\nInforme o tamanho do primero vetor desejado: ");
            numeroDigitado1 = int.Parse(Console.ReadLine());

            Console.Write("\n\nInforme o tamanho do segundo vetor desejado: ");
            numeroDigitado2 = int.Parse(Console.ReadLine());

            vetorPrimario = CriaVetor(numeroDigitado1, "\nCriação do Primeiro Vetor!");
            vetorSecundario = CriaVetor(numeroDigitado2, "\nCriação do Segundo Vetor!");

            MaioresElementosVetor(vetorPrimario, vetorSecundario);

            Multiplos(vetorPrimario, vetorSecundario);

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
        }

        static int[] CriaVetor(int tamanhoVetor, string msg)
        {
            int[] vetorCriado = new int[tamanhoVetor];
            int numeroInformado;

            Console.WriteLine(msg);
            Console.WriteLine("\n\nInforme os números para compor o Vetor!\n");

            for(int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write((i+1) + "º Elemento : ");
                numeroInformado = int.Parse(Console.ReadLine());
                vetorCriado[i] = numeroInformado;
            }
            return (vetorCriado);
        }

        static void MaioresElementosVetor(int[] vetorPrimario, int[] vetorSecundario)
        {
            int contador;

            Console.WriteLine("\n\nElementos do primeiro vetor que são maiores que todos os elementos do segundo: ");

            for (int i = 0; i < vetorPrimario.Length; i++)
            {
                contador = 0;

                for (int j = 0; j < vetorSecundario.Length; j++)
                {
                    if(vetorPrimario[i] > vetorSecundario[j])
                    {
                        contador++;
                    }
                }

                if(contador == vetorSecundario.Length)
                {
                    Console.Write($"{vetorPrimario[i]} ");
                }
                Console.WriteLine();
            }
        }

        static void Multiplos(int[] vetorPrimario, int[] vetorSecundario)
        {
            int contador;

            Console.WriteLine("Elementos do primeiro vetor que são múltiplos de todos os elementos do segundo: ");

            for (int i = 0; i < vetorPrimario.Length; i++)
            {
                contador = 0;

                for (int j = 0; j < vetorSecundario.Length; j++)
                {
                    if (vetorPrimario[i] % vetorSecundario[j] == 0)
                    {
                        contador++;
                    }
                }

                if (contador == vetorSecundario.Length)
                {
                    Console.Write($"{vetorPrimario[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
