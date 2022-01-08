using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{
    public class Atividades_25_08_2021
    {
        public static void Aula_25_08_2021()
        {
            string opcao = "S";
            
            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>  Exercícios Realizados no dia 25/08/2021  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Media de Tres Numerosn\n2 - Trabalho Com Arame\n3 - Caixa D'Agua Quadrada\n4 - Cofre\n5 - Caixa D'Agua Cilindrica");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_01_MediaDeTresNumeros.MediaTresNumeros();
                        break;
                    case 2:
                        Exercicio_02_TrabalhoComArame.TrabalhoComArame();
                        break;
                    case 3:
                        Exercicio_03_CaixaDAguaQuadrangular.CaixaDAguaQuadrada();
                        break;
                    case 4:
                        Exercicio_04_DinherioNoCofre.DinheiroNoCofre();
                        break;
                    case 5:
                        Exercicio_05_CaixaDAguaCilindrica.CaixaDAguaCilindrica();
                        break;
                    default:
                        Console.WriteLine("Opção digitada inválida!");
                        break;
                }

                Console.WriteLine("\n\nDeseja realizar outra operacao:\nS = Sim  ou N = Não");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");
        }
    }
}
