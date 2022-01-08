using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_12_2021
{
    public class Exercicio_03
    {
        public static void Exercicio_3_ProvaFinal()
        {
            /*
             *Faça um programa em C# que:
                a) leia um número inteiro positivo n;
                b) crie uma matriz de números inteiros de 2 linhas e n colunas e um vetor de valores booleanos de tamanho n;
                c) preencha a matriz com valores informados pelo usuário;
                d) armazene em cada posição i do vetor: o valor verdadeiro, se M[0,i] for múltiplo de M[1,i]; e falso, caso contrário;
                e) exiba o conteúdo do vetor. 
             */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercicio 3<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int quantidadeColuna, numeroInformado;
            bool[] existeNumero;
            int[,] matriz;


            Console.Write("\n\nInforme a quantidade desejada de colunas da Matriz: ");
            quantidadeColuna = int.Parse(Console.ReadLine());

            matriz = CriaMatriz(2, quantidadeColuna);
            ExibeMatriz(matriz);

            AnaliseItensMatriz(matriz, quantidadeColuna);
        }

        static int[,] CriaMatriz(int linha, int coluna)
        {
            int[,] matrizCriada = new int[linha, coluna];
            int elemento;

            Console.WriteLine("\n\nInformando os elementos da Matriz!\n\n");

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write((i + 1) + "ª Linha e " + (j + 1) + "ª Coluna: ");
                    elemento = int.Parse(Console.ReadLine());
                    matrizCriada[i, j] = elemento;
                }
            }
            return (matrizCriada);
        }

        static void ExibeMatriz(int[,] matrizInformada)
        {
            Console.WriteLine("\n\nMatriz Criada!\n\n");

            for (int i = 0; i < matrizInformada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizInformada.GetLength(1); j++)
                {
                    if (j == matrizInformada.GetLength(1) - 1)
                    {
                        Console.Write($"{matrizInformada[i, j]}\n");
                    }
                    else
                    {
                        Console.Write($"{matrizInformada[i, j]}, ");
                    }
                }
            }
        }

        static void ExibeVetoGeral(bool[] vetorInformado)
        {
            Console.WriteLine("\n\nVetor com Expressoes Booleanas!\n\n");

            for (int i = 0; i < vetorInformado.Length; i++)
            {
                if (i == (vetorInformado.Length - 1))
                {
                    Console.Write($"{vetorInformado[i]}\n");
                }
                else
                {
                    Console.Write($"{vetorInformado[i]}, ");
                }
            }
        }

        static void AnaliseItensMatriz(int[,] matrizInformada, int tamanhoColuna)
        {
            int contador, elementoComparacao = 0;
            bool[] vetorAnaliseRealizada = new bool[tamanhoColuna];

            for (int i = 0; i < matrizInformada.GetLength(0); i++)
            {

                for (int j = 0; j < matrizInformada.GetLength(0); j++)
                {

                    elementoComparacao = matrizInformada[i, j];

                    for (int w = 1; w < matrizInformada.GetLength(1); w++)
                    {
                        contador = 0;
                        if (elementoComparacao % 2 == 0)
                        {

                            vetorAnaliseRealizada[contador] = true;
                            contador++;
                        }
                        else
                        {
                            vetorAnaliseRealizada[contador] = false;
                            contador++;
                        }
                    }
                }

            }

            ExibeVetoGeral(vetorAnaliseRealizada);
        }
    }
}
