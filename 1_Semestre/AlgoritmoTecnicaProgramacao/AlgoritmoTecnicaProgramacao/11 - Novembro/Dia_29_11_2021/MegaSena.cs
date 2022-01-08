using System;
using System.Collections.Generic;


namespace AlgoritmoTecnicaProgramacao.Dia_29_11_2021
{
    public class MegaSena
    {
        public static void JogoMegaSena()
        {
            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Jogo Mega Sena<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int quantidadeDezenasApostadas = 0;
            int[] dezenasApostadas, dezenasSorteadas, dezenasAcertadas;


            do
            {
                Console.WriteLine("\n\nDigite quantos números deseja jogar entre 6 e 15: ");
                quantidadeDezenasApostadas = int.Parse(Console.ReadLine());

            } while(!ValidaDezenaInformada(quantidadeDezenasApostadas, 6, 15));


            Console.WriteLine("\n\nDigite os números que deseja jogar entre 1 e 60: \n");

            dezenasApostadas = CriaVetorSemRepeticao(quantidadeDezenasApostadas, 1, 60, "\nDezenas Apostadas!");

            //dezenasSorteadas = CriaVetorSemRepeticao(quantidadeDezenasApostadas, 1, 60, "\nDezenas Sorteadas!");

            //dezenasAcertadas = CriaVetorSemRepeticao(quantidadeDezenasApostadas, 1, 60, "\nDezenas Acertadas!");

            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
        }

        static bool ValidaDezenaInformada(int dezena, int limiteInferior, int limiteSuperior)
        {
            if((dezena < limiteInferior) || (dezena > limiteSuperior))
            {
                return false;
            }
            return true;
        }

        static int[] CriaVetorSemRepeticao(int tamanho, int limiteInferior, int limiteSuperior, string msg)
        {
            int[] vetorCriado = new int[tamanho];
            int dezenaInformada;

            for(int i = 0; i < tamanho; i++)
            {
                do
                {
                    Console.Write(i + 1 + "º Número = ");
                    dezenaInformada = int.Parse(Console.ReadLine());

                } while((ValidaNumeroRepetido(dezenaInformada, vetorCriado)) || !ValidaDezenaInformada(dezenaInformada, limiteInferior, limiteSuperior));

                vetorCriado[i] = dezenaInformada;
            }

            return (vetorCriado);
        }

        static bool ValidaNumeroRepetido(int numeroValidacao, int[] validacao)
        {
            for(int i = 0; i < validacao.Length; i++)
            {
                if(numeroValidacao == validacao[i])
                {
                    return true;
                }                
            }
            return false;
        }

    }
}
