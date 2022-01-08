using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_12_2021
{
    public class Prova
    {
        public static void ProvaFinal()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Segunda Prova<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_01.Exercicio_1_ProvaFinal();
                        break;
                    case 2:
                        Exercicio_02.Exercicio_2_ProvaFinal();
                        break;
                    case 3:
                        Exercicio_03.Exercicio_3_ProvaFinal();
                        break;
                    default:
                        Console.WriteLine("Opção digitada é invalida!");
                        break;
                }
               
                Console.WriteLine("\n\n\nDeseja acessar outro exercicio?");
                opcao = Console.ReadLine().ToUpper();

            } while(opcao != "N");
        }
    }
}
