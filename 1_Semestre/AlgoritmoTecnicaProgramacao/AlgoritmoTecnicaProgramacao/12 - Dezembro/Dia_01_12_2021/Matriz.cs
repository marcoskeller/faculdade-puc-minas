using System;


namespace AlgoritmoTecnicaProgramacao.Dia_01_12_2021
{
    public class Matriz
    {
        public static void AprendendoMatriz()
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
            } while((quantidadeLinhas < 0) && (quantidadeColunas < 0));


            matriz = CriaMatriz(quantidadeLinhas, quantidadeColunas);
            
            ExibeMatriz(matriz);
        }

        static int[,] CriaMatriz(int linha, int coluna)
        {
            int[,] matrizCriada = new int[linha, coluna];
            int elemento;
            
            Console.WriteLine("\n\nInformando Elementos da Matriz\n\n");

            for(int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    Console.Write((i+1) + "ª linha e " + (j+1) + "ª coluna: ");
                    elemento = int.Parse(Console.ReadLine());
                    matrizCriada[i, j] = elemento;
                }
            }

            return (matrizCriada);
        }

        static void ExibeMatriz(int[,] matriz)
        {
            Console.WriteLine("\n\nMatriz Criada!\n\n");

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(j == matriz.GetLength(1) - 1)
                    {
                        Console.Write($"{ matriz[i, j]}\n");
                    }
                    else
                    {
                        Console.Write($"{ matriz[i, j]}, ");
                    }                    
                }
            }
        }
    }
}
