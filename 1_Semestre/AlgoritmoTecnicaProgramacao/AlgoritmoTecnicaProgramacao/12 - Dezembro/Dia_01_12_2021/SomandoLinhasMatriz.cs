using System;


namespace AlgoritmoTecnicaProgramacao.Dia_01_12_2021
{
    public class SomandoLinhasMatriz
    {
        public static void SomandoLinhasMatrizGerandoVetor()
        {
            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Somatório das Linhas da Matriz<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int quantidadeLinhas, quantidadeColunas;
            int[,] matriz;
            int[] vetorSoma;

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

            vetorSoma = SomaLinhasMatrizCriandoVetor(matriz);

            ExibeVetoSoma(vetorSoma);

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

        static int[] SomaLinhasMatrizCriandoVetor(int[,] matrizInformada)
        {            
            int[] vetorSoma = new int[matrizInformada.GetLength(0)];

            for(int i = 0; i < matrizInformada.GetLength(0); i++)
            {
                int somaLinha = 0;

                for (int j = 0; j < matrizInformada.GetLength(1); j++)
                {
                    somaLinha = somaLinha + matrizInformada[i, j];
                }
                vetorSoma[i] = somaLinha;
            }

            return (vetorSoma);
        }

        static void ExibeVetoSoma(int[] vetorInformado)
        {
            Console.WriteLine("\n\nVetor Criado com o Somatório das Linhas!\n\n");

            for(int i = 0; i < vetorInformado.Length; i++)
            {
                if(i == (vetorInformado.Length - 1))
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
