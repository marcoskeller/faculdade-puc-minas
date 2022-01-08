using System;

namespace AlgoritmoTecnicaProgramacao.Exercicios_Diversos_Professor
{
    public class Atividades_Professor
    {
        public static void ExerciciosMateria()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Diversos Exercícios<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Estruturas_Condicionais_Do_While\n\n2 - Estruturas_Condicionais_For\n\n3 - Estruturas_Condicionais_If_Else\n\n4 - Estruturas_Condicionais_Switch_Case\n\n5 - Estruturas_Condicionais_While\n\n6 - Futuro");
                
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.Write("\n\nDigite qual exercício deseja  executar: ");


                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Estruturas_Repeticao_Do_While.EstruturasRepeticao();
                        break;
                    case 2:
                        //
                        break;
                    case 3:
                        //
                        break;
                    case 4:
                        //
                        break;
                    case 5:
                        //
                        break;
                    default:
                        Console.WriteLine("\n\nOpção Inválida!");
                        break;
                }
            } while (opcao != "N");
        }
    }
}
