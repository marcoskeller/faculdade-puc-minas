using System;
using Trabalho_ATP_CompanhiaAerea_1.Cadastro;
using Trabalho_ATP_CompanhiaAerea_1.Relatorio;

namespace Trabalho_ATP_CompanhiaAerea_1
{
    public class Startup
    {
        public static void Inicio()
        {
            string opcao;
            int operacao;

            CadastroCompanhiaAerea.CadastroCompanhiaAereaGeral();
            
            Console.Clear();
            Console.WriteLine("\n\nCompanhia " + CadastroCompanhiaAerea.nomeCompanhiaAerea + "\nFundada em ("+ CadastroCompanhiaAerea.anoFundacao + ").");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.WriteLine("\n1  - Cadastrar Companhia Aérea\n2  - Cadastro de Aeronaves\n3  - Relatórios");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite Qual Funcionalidade Deseja Acessar: ");
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    CadastroCompanhiaAerea.CadastroCompanhiaAereaGeral();
                    break;
                case 2:
                    CadastroAeronave.CadastroAeronaveGeral();
                    break;
                case 3:
                    RelatorioGeral.Relatorio();
                    break;          
                case 4:
                    CadastroCliente.CadastroClienteGeral();
                    break;
                case 5:
                    CadastroFuncionario.CadastroFuncionarioGeral();
                    break;


                default:
                    Console.WriteLine("Opção Inválida! Favor digitar um opção informada no Menu Inicial!");
                    break;
            }
        }
    }
}