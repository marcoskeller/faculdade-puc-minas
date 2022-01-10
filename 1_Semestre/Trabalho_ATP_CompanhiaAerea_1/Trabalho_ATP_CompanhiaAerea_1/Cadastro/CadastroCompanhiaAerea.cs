using System;
using Trabalho_ATP_CompanhiaAerea_1.DTO;

namespace Trabalho_ATP_CompanhiaAerea_1.Cadastro
{    
    public class CadastroCompanhiaAerea : CompanhiaAerea
    {
        public static string nomeCompanhiaAerea;
        public static int anoFundacao;

        public static string CadastroCompanhiaAereaGeral()
        {
            var companhia = new CompanhiaAerea();

            Console.Write("\n\nDigite o nome da Companhia Aérea: ");
            nomeCompanhiaAerea = Console.ReadLine();

            Console.Write("\n\nDigite o ano da fundacao da Companhia Aérea: ");
            anoFundacao = int.Parse(Console.ReadLine());

            companhia.NomeCompanhiaAerea = nomeCompanhiaAerea;
            companhia.AnoFundacao = anoFundacao;

            return companhia.ToString();
        }
    }
}