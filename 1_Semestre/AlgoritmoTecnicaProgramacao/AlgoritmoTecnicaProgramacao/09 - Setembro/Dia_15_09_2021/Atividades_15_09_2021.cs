using System;

namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class Atividades_15_09_2021
    {
        public static void Aula_15_09_2021()
        {
            string opcao = "S";
            
            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Realizados<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03\n4 - Exercicio_04 \n5 - Exercicio_05");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");


                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        ValidaHorasDigitada.ValidaHoras();
                        break;
                    case 2:
                        CalculoSalario.SalarioTotal();
                        break;
                    case 3:
                        CalculoRaizesEquacao.EquacaoSegundoGrau();
                        break;
                    case 4:
                        SituacaoEscolarAluno.SituacaoAluno();
                        break;
                    case 5:
                        Calculadora.CalculadoraBasica();
                        break;             
                    default:
                        Console.WriteLine("Opção digitada é invalida!");
                        break;
                }
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.Write("\n\nDeseja acessar outro exercício: ");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");
        }
    }
}
