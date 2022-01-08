using System;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class Atividades_22_09_2021
    {
        public static void Aula_22_09_2021()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Realizados<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Raiz Quadrada\n2 - Caixa D'Agua\n3 - Conta Bancária\n4 - Posto de Combustível\n5 - Grafo");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");
                
                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Dia_22_09_2021.Exercicio_01_RaizQuadrada.RaizQuadrada();
                        break;
                    case 2:
                        Dia_22_09_2021.Exercicio_02_CaixaDAgua.CaixaDAgua();
                        break;
                    case 3:
                        Dia_22_09_2021.Exercicio_03_ContaBancaria.ContaBancaria();
                        break;
                    case 4:
                        Dia_22_09_2021.Exercicio_04_PostoDeCombustivel.PostoCombustivel();
                        break;
                    case 5:
                        Dia_22_09_2021.Exercicio_05_Grafo.Grafo();
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
