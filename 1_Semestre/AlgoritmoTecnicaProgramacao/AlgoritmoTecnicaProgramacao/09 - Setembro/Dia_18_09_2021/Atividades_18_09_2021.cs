using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class Atividades_18_09_2021
    {      
        public static void Aula_18_09_2021()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Realizados<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Senha Bancária\n2 - Partida de Futebol\n3 - Tipo de Eleitor\n4 - Mensalidade do Clube\n5 - Indíce Massa Corporal\n6 - Torres de Hanoi");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");
                
                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_01_SenhaBancaria.SenhaBancaria();
                        break;
                    case 2:
                        Exercicio_02_PartidaFutebol.PartidaFutbeol();
                        break;
                    case 3:
                        Exercicio_03_TipoEleitor.TipoEleitor();
                        break;
                    case 4:
                        Exercicio_04_MensalidadeClube.MensalidadeClube();
                        break;
                    case 5:
                        Exercicio_05_IndiceMassaCorporal.IndiceMassaCorporal();
                        break;
                    case 6:
                        Exercicio_06_TorresDeHanoi.TorresDeHanoi();
                        break;
                    default:
                        break;
                }

                Console.Write("\n\nDeseja acessar outro exercício: ");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");

        }
    }
}

