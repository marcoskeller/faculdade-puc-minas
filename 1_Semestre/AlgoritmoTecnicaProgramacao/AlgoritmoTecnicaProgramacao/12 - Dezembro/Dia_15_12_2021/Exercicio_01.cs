using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_12_2021
{
    public class Exercicio_01
    {
        public static void Exercicio_1_ProvaFinal()
        {
            /*
             *Faça um programa em C# com os seguintes módulos:

                 a) CriaMatriz: recebe como parâmetros dois números inteiros positivos m e n, 
                    cria uma matriz de números inteiros de m linhas e n colunas e a preenche com valores informados pelo usuário. 
                    A matriz deve ser devolvida como resultado;

                 b) MediaLinhas: recebe como parâmetro uma matriz de números inteiros, cria um vetor de números reais de m posições 
                   (m é o número de linhas da matriz), calcula e armazena em cada posição i do vetor a média dos elementos da linha i da matriz. 
                   O vetor deve ser devolvido como resultado;

                 c) ExibeMatriz: recebe como parâmetro uma matriz de números inteiros e a exibe na tela;

                 d) ExibeVetor: recebe como parâmetro um vetor de números inteiros e o exibe na tela.

                 O módulo principal deve permitir a chamada dos módulos. Os resultados devem ser exibidos na tela. 
            */

            int[,] matriz;
            double[] mediaElementosLinhaMatriz;
            int quantidadeLinha, quantidadeColuna;

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercicio 1<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nInforme quantas linhas a Matriz tera: ");
            quantidadeLinha = int.Parse(Console.ReadLine());

            Console.Write("\nInforme quantas colunas a Matriz tera: ");
            quantidadeColuna = int.Parse(Console.ReadLine());

            matriz = CriaMatriz(quantidadeLinha, quantidadeColuna);

            ExibiMatriz(matriz, "Matriz Inicial!");

            mediaElementosLinhaMatriz = MediaValoresLinhasMatriz(matriz);
            
            ExibeVetor(mediaElementosLinhaMatriz, "Médias dos Valores das Linhas da Matriz!");

        }

        public static int[,] CriaMatriz(int linha, int coluna)
        {
            int[,] matriz = new int[linha, coluna];
            int elementoMatriz;

            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write("\n" + (j+1) + "º Elemento da "+ (i+1) + "ª Linha e " + (j + 1) + "º Elemento da " + (j + 1) + "ª Coluna: ");
                    elementoMatriz = int.Parse(Console.ReadLine());
                    matriz[i, j] = elementoMatriz;
                }
            }

            return matriz;
        }

        public static void ExibiMatriz(int[,] matrizInformada, string msg)
        {
            Console.WriteLine($"\n\n{msg}\n\n");

            for (int i = 0; i < matrizInformada.GetLength(0); i++)
            {
                for(int j = 0; j < matrizInformada.GetLength(1); j++)
                {
                    if(j == matrizInformada.GetLength(1) - 1)
                    {
                        Console.Write($"{matrizInformada[i,j]}\n");
                    }
                    else
                    {
                        Console.Write($"{matrizInformada[i, j]}, ");
                    }
                }
            }
        }

        public static double[] MediaValoresLinhasMatriz(int[,] matrizInformada)
        {
            double[] vetorMedia = new double[matrizInformada.GetLength(0)];
            
            double mediaValoresLinhaMatriz = 0;

            for(int i = 0; i < matrizInformada.GetLength(0); i++)
            {
                int somaNumerosLinhaMatriz = 0;

                for (int j = 0; j < matrizInformada.GetLength(1); j++)
                {
                    somaNumerosLinhaMatriz = somaNumerosLinhaMatriz + matrizInformada[i, j];
                }

                vetorMedia[i] = somaNumerosLinhaMatriz / matrizInformada.GetLength(1);
            }

            return vetorMedia;
            
        }

        public static void ExibeVetor(double[] vetorInformado, string msg)
        {
            Console.WriteLine($"\n\n{msg}\n\n");

            for(int i = 0; i < vetorInformado.Length; i++)
            {
                if(i == vetorInformado.Length - 1)
                {
                    Console.Write($"{vetorInformado[i]}\n");
                }
                else
                {
                    Console.Write($"{vetorInformado[i]}, ");
                }
            }
        }


    }
}
