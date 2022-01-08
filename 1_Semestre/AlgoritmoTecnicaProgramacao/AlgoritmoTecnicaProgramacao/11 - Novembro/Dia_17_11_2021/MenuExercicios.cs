using System;


namespace AlgoritmoTecnicaProgramacao.Dia_17_11_2021
{
    public class MenuExercicios
    {
        public static void AcessarMenuExercicios()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Segunda Prova<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - 17/11/2021 - Trabalhando com Vetores\n2 - 22/11/2021 - Exercicios Laboratorio 6\n");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        OperacoesBasicasComVetor.TrabalhandoVetores();
                        break;
                    case 2:
                        ExerciciosLaboratorio_6.AcessarExerciciosLaboratorio_6();
                        break;
                    case 3:
                        //Sair
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
