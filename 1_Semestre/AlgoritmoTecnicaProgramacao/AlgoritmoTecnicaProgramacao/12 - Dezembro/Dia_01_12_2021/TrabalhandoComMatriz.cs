using System;


namespace AlgoritmoTecnicaProgramacao.Dia_01_12_2021
{
    public class TrabalhandoComMatriz
    {
        public static void TrabalhandoComElementosMatriz()
        {
            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Somatório dos Elementos da Matriz<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int quantidadeLinhas, quantidadeColunas;
            int[,] matriz;

            do
            {
                Console.WriteLine("\n\nDados para criar a Matriz!\n\n");

                Console.Write("Informe a quantidade de linhas: ");
                quantidadeLinhas = int.Parse(Console.ReadLine());

                Console.Write("Informe a quantidade de colunas: ");
                quantidadeColunas = int.Parse(Console.ReadLine());
            } while ((quantidadeLinhas < 0) && (quantidadeColunas < 0));

            matriz = CriaMatriz(quantidadeLinhas, quantidadeColunas);

            ExibeMatriz(matriz);

            ExibiSomaMatriz(matriz);

        }

        static int[,] CriaMatriz(int linha, int coluna)
        {
            int[,] matrizCriada = new int[linha, coluna];
            int elemento;

            Console.WriteLine("\n\nInformando os elementos da Matriz!\n\n");

            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write((i+1) + "ª Linha e " + (j+1) + "ª Coluna: ");
                    elemento = int.Parse(Console.ReadLine());
                    matrizCriada[i, j] = elemento;
                }
            }
            return (matrizCriada);
        }

        static void ExibeMatriz(int[,] matrizInformada)
        {
            Console.WriteLine("\n\nMatriz Criada!\n\n");

            for(int i = 0; i < matrizInformada.GetLength(0); i++)
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

        static void ExibiSomaMatriz(int[,] matrizInformada)
        {
            int somatorioTotalElementos = 0, somatorioDiagonalPrincipal = 0, 
                somatorioElementosAbaixoDiagonalPrincipal = 0, somatorioElementosAcimaDiagonalPrincipal = 0;

            for(int i = 0; i < matrizInformada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizInformada.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        somatorioDiagonalPrincipal = somatorioDiagonalPrincipal + matrizInformada[i, j];
                    }
                    else if( i > j)
                    {
                        somatorioElementosAbaixoDiagonalPrincipal = somatorioElementosAbaixoDiagonalPrincipal + matrizInformada[i, j];
                    }
                    else
                    {
                        somatorioElementosAcimaDiagonalPrincipal = somatorioElementosAcimaDiagonalPrincipal + matrizInformada[i,j];
                    }
                }
            }

            somatorioTotalElementos = somatorioDiagonalPrincipal + somatorioElementosAbaixoDiagonalPrincipal + somatorioElementosAcimaDiagonalPrincipal;

            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>Resultado do Somatório<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
            Console.WriteLine("Soma dos Elementos da Diagonal Principal: " + somatorioDiagonalPrincipal);
            Console.WriteLine("\nSoma dos Elementos Abaixo da Diagonal Principal: " + somatorioElementosAbaixoDiagonalPrincipal);
            Console.WriteLine("\nSoma dos Elementos Acima da Diagonal Principal: " + somatorioElementosAcimaDiagonalPrincipal);
            Console.WriteLine("\nSoma de todos os Elementos da Matriz: " + somatorioTotalElementos);
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n\n");
        }
    }
}
