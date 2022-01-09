using System;


namespace AlgoritmoTecnicaProgramacao._12___Dezembro.Dia_01_12_2021
{
    public class MatrizGeral
    {
        public static void TrabalhandoMatrizGeral()
        {
            /*
            Faça um programa em C# que:
               a) leia um número inteiro n, correspondente às dimensões de uma matriz quadrada;
               b) leia números inteiros e os armazene em uma matriz n x n;
               c) calcule as somas dos elementos: 
                   (1) da matriz, 
                   (2) da diagonal principal, 
                   (3) abaixo da diagonal principal, e 
                   (4) acima da diagonal principal. 
            */
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>Matriz<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int tamanhoMatriz, elementoMatriz, contador = 1;
            int[,] matriz;


            Console.Write("\n\nInforma o tamanho da matriz: ");
            tamanhoMatriz = int.Parse(Console.ReadLine());


            matriz = CriaMatrizDesejada(tamanhoMatriz, tamanhoMatriz);

            ExibeMatriz(matriz);

            ExibiSomaElementoMatriz(matriz);




            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        static int[,] CriaMatrizDesejada(int tamanhoLinha, int tamanhaColuna)
        {
            int tamanhoMatriz, elementoMatriz, contador = 1;
            int[,] matriz;

            matriz = new int[tamanhoLinha, tamanhaColuna];

            Console.WriteLine();
            Console.Write("\n\nDigite os elementos da Matriz!\n\n");

            for (int i = 0; i < tamanhoLinha; i++)
            {
                for (int j = 0; j < tamanhaColuna; j++)
                {
                    Console.Write(i + 1 + "ª linha e " + (j + 1) + "ª coluna: ");
                    elementoMatriz = int.Parse(Console.ReadLine());
                    matriz[i, j] = elementoMatriz;
                    contador++;

                }
            }

            return (matriz);
        }

        static void ExibeMatriz(int[,] matrizInformada)
        {
            int i, j;

            Console.WriteLine();

            for (i = 0; i < matrizInformada.GetLength(0); i++)
            {
                for (j = 0; j < matrizInformada.GetLength(1); j++)
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

        static void ExibiSomaElementoMatriz(int[,] matriz)
        {
            int somaTotalElementosMatriz = 0, somaElementosDiagonal = 0, somaElemntosACD = 0, somaElementosABD = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        somaElementosDiagonal = somaElementosDiagonal + matriz[i, j];
                    }
                    else if (i > j)
                    {
                        somaElementosABD = somaElementosABD + matriz[i, j];
                    }
                    else
                    {
                        somaElemntosACD = somaElemntosACD + matriz[i, j];
                    }
                }
            }
            somaTotalElementosMatriz = somaElementosDiagonal + somaElementosABD + somaElemntosACD;

            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Resultado<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("\n\nSomatório Elementos da Diagonal Principal: " + somaElementosDiagonal);
            Console.WriteLine("Somatório Elementos Abaixo da Diagonal Principal: " + somaElementosABD);
            Console.WriteLine("Somatório Elementos Acima da Diagonal Principal: " + somaElemntosACD);
            Console.WriteLine("Somatório de Todos os Elementos da Matriz: " + somaTotalElementosMatriz);
        }
    }
}
