using System;


namespace AlgoritmoTecnicaProgramacao.Dia_08_12_2021
{
    public class RefatorandoVetores
    {
        public static void RefatorandoVetores_08_12_2021()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Refatoração de Vetores<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Fatorial\n2 - Refatoração_Vetor_Contagem_01\n3 - Refatoração_Vetor_Contagem_02\n4 - Refatoração_Vetor_Contagem_03\n5 - Sair");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_Fatorial.Fatorial();
                        break;
                    case 2:
                        AnalisaQuantasVezesNumeroAparece.QuantasVezesNumeroApareceVetor();
                        break;
                    case 3:
                        PrimeiraRefatoracaoAnalisaQuantasVezesNumeroAparece.PrimeiraRefatoracaoAnalisaQuantasVezesNumeroApareceVetor();
                        break;
                    case 4:
                        SegundaRefatoracaoAnalisaQuantasVezesNumeroAparece.SegundaRefatoracaoAnalisaQuantasVezesNumeroApareceVetor();
                        break;
                    case 5:
                        //Sair;
                        break;
                    default:
                        Console.WriteLine("Opção digitada é invalida!");
                        break;
                }


                Console.WriteLine("\n\n\nDeseja acessar outro exercicio?");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");
        }
    }
}
