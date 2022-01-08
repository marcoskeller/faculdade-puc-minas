using System;


namespace AlgoritmoTecnicaProgramacao.Dia_24_11_2021
{
    public class Exercicios_24_11_2021
    {
        public static void AcessarExercicios_24_11_2021()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Segunda Prova<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03\n4 - Exercicio_04\n5 - Exercicio_05");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        ExerciciosLaboratorio_7_Keller.ExerciciosLaboratorio_7_Keller_Exercicio_1();
                        break;
                    case 2:
                        ExerciciosLaboratorio_7_Keller.ExerciciosLaboratorio_7_Keller_Exercicio_2();
                        break;
                    case 3:
                        ExerciciosLaboratorio_7_Keller.ExerciciosLaboratorio_7_Keller_Exercicio_3();
                        break;
                    case 4:
                        ExerciciosLaboratorio_7_Keller.ExerciciosLaboratorio_7_Keller_Exercicio_4();
                        break;
                    case 5:
                        ExerciciosLaboratorio_7_Keller.ExerciciosLaboratorio_7_Keller_Exercicio_5();
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
