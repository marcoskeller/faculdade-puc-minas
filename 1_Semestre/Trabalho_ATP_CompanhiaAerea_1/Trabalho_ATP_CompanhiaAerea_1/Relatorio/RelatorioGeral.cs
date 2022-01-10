using System;


namespace Trabalho_ATP_CompanhiaAerea_1.Relatorio
{
    public class RelatorioGeral
    {
        public static void Relatorio()
        {
            string opcao;
            int operacao;

            Console.Clear();
            Console.WriteLine("\n\n                 Companhia Aérea Voe Alto");
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Relatório<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


            Console.WriteLine("\n1  - Relatório Aeronave(s)\n2  - Relatório Companhia Aérea\n3  - Relatório Funcionário(s)\n4  - Relatório Cliente(s)");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite Qual Funcionalidade Deseja Acessar: ");
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    RelatorioAeronaves.RelatorioAeronavesEspecifico();
                    break;
                case 2:
                    RelatorioCompanhiaAerea.RelatorioCompanhiaAereaEspecifico();
                    break;
                case 3:
                    RelatorioFuncionario.RelatorioFuncionarioEspecifico();
                    break;
                case 4:
                    RelatorioCliente.RelatorioClienteEspecifico();
                    break;
                case 5:
                    RelatorioGeral.Relatorio();
                    break;

                default:
                    Console.WriteLine("Opção Inválida! Favor digitar um opção informada no Menu Inicial!");
                    break;
            }
        }
    }
}
