using System;


namespace AlgoritmoTecnicaProgramacao.Dia_19_10_2021
{
    public class Prova_19_10_2021
    {
        public static void Prova_1()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Realizados<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03");
                
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                
                int operacao;

                Console.Write("\n\nDigite qual exercício deseja  executar: ");              
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_01.Exercicio_01_Prova();
                        break;
                    case 2:
                        Exercicio_02.Exercicio_02_Prova();
                        break;
                    case 3:
                        Exercicio_03.Exercicio_03_Prova();
                        break;
                    default:
                        Console.WriteLine("Opção digitada é invalida!");
                        break;
                }

                Console.Write("\n\nDeseja acessar outro exercício: ");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");
        }
    }
}
