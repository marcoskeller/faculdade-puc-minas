using System;


namespace AlgoritmoTecnicaProgramacao.Dia_24_11_2021
{
    public class ExerciciosLaboratorio_7_Keller
    {
        public static void ExerciciosLaboratorio_7_Keller_Exercicio_1()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>AtividadeLaboratorio_7<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            /*
             * 1) Faça um programa em C# para:
                    a) ler um vetor V de n números inteiros (o valor de n deve ser informado pelo usuário);
                    b) copiar os valores positivos de V para um vetor VP sem deixar elementos vazios entre os elementos de VP;
                    c) exibir os elementos do vetor VP;
                    d) calcular e mostrar a soma e a média dos valores armazenados no vetor VP.
             */

            int tamanhoVetor;
            int[] vetorPrincipal;

            Console.Write("\n\nInforma a quantidade de números que o vetor terá:");
            tamanhoVetor = int.Parse(Console.ReadLine());

            vetorPrincipal = CriaVetor(tamanhoVetor, "\n\nVetor Para Avaliar os Numeros!");


            Console.WriteLine("\n\nO vetor formado é : " + CriaVetorSecundario(vetorPrincipal));

            static int[] CriaVetor(int tamanho, string msg)
            {
                int[] vetorCriado = new int[tamanho];
                int numeroInformado;

                Console.WriteLine(msg);
                Console.WriteLine("\n\nInforme os números para o vetor que será criado.\n");

                for (int i = 0; i < tamanho; i++)
                {

                    Console.Write(i + 1 + "º Número: ");
                    numeroInformado = int.Parse(Console.ReadLine());
                    vetorCriado[i] = numeroInformado;
                }
                return (vetorCriado);
            }

            static int[] CriaVetorSecundario(int[] vetor)
            {
                int[] vetorSecundario;
                int quantidadeNumerosPositivos = 0, contadorVetorSecundario = 0;

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] > 0)
                    {
                        quantidadeNumerosPositivos++;
                    }
                }

                vetorSecundario = new int[quantidadeNumerosPositivos];

                Console.WriteLine("\n\nNumeros Positivos.\n");

                for (int i = 0; i < vetor.Length; i++)
                {
                    //Console.Write(i + 1 + "º Número: ");
                    if (vetor[i] > 0)
                    {
                        vetorSecundario[contadorVetorSecundario] = vetor[i];
                        contadorVetorSecundario++;
                    }

                }
                return (vetorSecundario);
            }
        }

        public static void ExerciciosLaboratorio_7_Keller_Exercicio_2()
        {
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>AtividadeLaboratorio_7<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            /*
             2) Faça em C# a função media, que:
                    a) receba como argumento um vetor de números inteiros;
                    b) calcule e devolva como resultado a média dos elementos presentes no vetor.
             */

            int tamanhoVetor;
            int[] vetorPrincipal;

            Console.Write("\n\nInforma a quantidade de números que o vetor terá:");
            tamanhoVetor = int.Parse(Console.ReadLine());

            vetorPrincipal = CriaVetor(tamanhoVetor, "\n\nVetor Para Calculo da Média!");


            Console.WriteLine("\n\nA média dos números do vetor é: " + CalculoMediaVetor(vetorPrincipal));

            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>FIM<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n");

            static int[] CriaVetor(int tamanho, string msg)
            {
                int[] vetorCriado = new int[tamanho];
                int numeroInformado;

                Console.WriteLine(msg);
                Console.WriteLine("\n\nInforme os números para o vetor que será criado.\n");

                for (int i = 0; i < tamanho; i++)
                {

                    Console.Write(i + 1 + "º Número: ");
                    numeroInformado = int.Parse(Console.ReadLine());
                    vetorCriado[i] = numeroInformado;
                }
                return (vetorCriado);
            }

            static double CalculoMediaVetor(int[] vetor)
            {
                int[] vetorSecundario;
                int somatorioNumeros = 0;
                double mediaNumeros = 0;


                for (int i = 0; i < vetor.Length; i++)
                {
                    somatorioNumeros = somatorioNumeros + vetor[i];
                }

                mediaNumeros = somatorioNumeros / vetor.Length;

                return (mediaNumeros);
            }
        }

        public static void ExerciciosLaboratorio_7_Keller_Exercicio_3()
        {
            /*
             3) Faça um programa em C# com os seguintes procedimentos e funções:
                    a) contagem: recebe um vetor de números inteiros V e um número inteiro x; calcula e retorna o número de vezes que x aparece em V;
                    b) analise: recebe um vetor de números inteiros; calcula e exibe quantas vezes cada elemento está presente no vetor.
             */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>AtividadeLaboratorio_7<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int tamanhoVetor, verificaNumero, quantidadeNumero = 0;

            int[] vetorNumeros;

            Console.Write("\n\nInforme qual será o tamanho do vetor:");
            tamanhoVetor = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            vetorNumeros = new int[tamanhoVetor];

            vetorNumeros = CriaVetor(tamanhoVetor, "Vetor que Será Testado!");
            QuantidadeVezesNumeroApareceVetor(vetorNumeros);


            static int[] CriaVetor(int tamanho, string msg)
            {
                int[] vetorCriado = new int[tamanho];
                int numeroInformado;

                Console.WriteLine(msg);
                Console.WriteLine("\n\nInforme os números para o vetor que será criado.\n");

                for (int i = 0; i < tamanho; i++)
                {

                    Console.Write(i + 1 + "º Número: ");
                    numeroInformado = int.Parse(Console.ReadLine());
                    vetorCriado[i] = numeroInformado;
                }
                return (vetorCriado);
            }

            static void QuantidadeVezesNumeroApareceVetor(int[] vetorPrincipal)
            {
                int verificaNumero, quantidadeNumero = 0;

                Console.Write("\n\nInforme o número para verificar quantas vezes ele aparece na sequencia:");
                verificaNumero = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 0; i < vetorPrincipal.Length; i++)
                {
                    if (vetorPrincipal[i] == verificaNumero)
                    {
                        quantidadeNumero = quantidadeNumero + 1;
                    }
                }

                Console.Write("\nO número " + verificaNumero + " apareceu " + quantidadeNumero + " vezes na sequencia.\n\n\n");
            }


            static void QuantidadeVezesCadaElementoApareceVetor(int[] vetorPrincipal)
            {
                int verificaNumero = 0, quantidadeNumero = 0;

                //Console.Write("\n\nInforme o número para verificar quantas vezes ele aparece na sequencia:");
                //verificaNumero = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 0; i < vetorPrincipal.Length; i++)
                {
                    if (vetorPrincipal[i] == verificaNumero)
                    {
                        verificaNumero = vetorPrincipal[i];
                    }
                }

                Console.Write("\nO número " + verificaNumero + " apareceu " + quantidadeNumero + " vezes na sequencia.\n\n\n");
            }
        }

        public static void ExerciciosLaboratorio_7_Keller_Exercicio_4()
        {
            /*
             4) Faça um programa em C# que:
                    a) leia dois valores inteiros positivos q1 e q2;
                    b) leia q1 números inteiros e os armazene em um vetor V1 (V1 não deve permitir elementos repetidos);
                    c) leia q2 números inteiros e os armazene em um vetor V2 (V2 deve permitir elementos repetidos);
                    d) para cada número presente no vetor V1 verifique quantas vezes ele está presente no vetor V2.
             */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>AtividadeLaboratorio_7<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int tamanhoVetorPrincipal, tamanhoVetorSecundario;
            int[] vetorPrincipal;
            int[] vetorSecundario;

            Console.Write("\n\nInforme o tamanho do Vetor Principal:");
            tamanhoVetorPrincipal = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("\n\nInforme o tamanho do Vetor Secundario:");
            tamanhoVetorSecundario = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            vetorPrincipal = new int[tamanhoVetorPrincipal];
            vetorSecundario = new int[tamanhoVetorSecundario];

            vetorPrincipal = CriaVetor(tamanhoVetorPrincipal, "\n\nVetor Principal!");
            vetorSecundario = CriaVetorSecundario(tamanhoVetorSecundario, "\n\nVetor Secundario!");
            QuantidadeVezesNumeroApareceVetor(vetorPrincipal, vetorSecundario);

            static int[] CriaVetor(int tamanho, string msg)
            {
                int[] vetorCriado = new int[tamanho];
                int numeroInformado;

                Console.WriteLine(msg);
                Console.WriteLine("\n\nInforme os números para o vetor que será criado.\n");

                for (int i = 0; i < tamanho; i++)
                {
                    do
                    {
                        Console.Write(i + 1 + "º Número: ");
                        numeroInformado = int.Parse(Console.ReadLine());

                    } while (ValidaNumeroPresente(numeroInformado, vetorCriado));

                    vetorCriado[i] = numeroInformado;
                }
                return (vetorCriado);
            }

            static int[] CriaVetorSecundario(int tamanho, string msg)
            {
                int[] vetorCriado = new int[tamanho];
                int numeroInformado;

                Console.WriteLine(msg);
                Console.WriteLine("\n\nInforme os números para o vetor que será criado.\n");

                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(i + 1 + "º Número: ");
                    numeroInformado = int.Parse(Console.ReadLine());
                    vetorCriado[i] = numeroInformado;

                }
                return (vetorCriado);
            }

            static bool ValidaNumeroPresente(int numero, int[] sequenciaInformada)
            {
                for (int i = 0; i < sequenciaInformada.Length; i++)
                {
                    if (sequenciaInformada[i] == numero)
                    {
                        return true;
                    }
                }
                return false;
            }

            static void QuantidadeVezesNumeroApareceVetor(int[] vetorSecundario, int[] vetorPrincipal)
            {
                int verificaNumero, quantidadeNumero = 0;

                Console.Write("\n\nInforme o número para verificar quantas vezes ele aparece na sequencia:");
                verificaNumero = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 0; i < vetorSecundario.Length; i++)
                {
                    if (vetorSecundario[i] == vetorPrincipal[i])
                    {
                        quantidadeNumero = quantidadeNumero + 1;
                    }
                }

                Console.Write("\nO número " + verificaNumero + " apareceu " + quantidadeNumero + " vezes na sequencia.\n\n\n");
            }
        }

        public static void ExerciciosLaboratorio_7_Keller_Exercicio_5()
        {
            //  Noa Realizado!
        }
    }
}
