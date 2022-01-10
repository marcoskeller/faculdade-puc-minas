using System;
using Trabalho_ATP_CompanhiaAerea_1.DTO;

namespace Trabalho_ATP_CompanhiaAerea_1.Cadastro
{
    public class CadastroAeronave : Aeronave
    {
        public static void CadastroAeronaveGeral()
        {
            string codigoAeronave = "", codigoAeronaveMaisAntiga = "", codigoAeronaveMaisAtual = "", modelo = "", modeloAeronaveMaisAntiga = "", modeloAeronaveMaisAtual = "";
            int quantidadeVoosRealizado = 0, quantidadeVoosAeronaveMaisAntiga = 0, quantidadeVoosAeronaveMaisAtual = 0,
                quantidadeAeronavesCompanhia = 0, anoFabricacao = 0, anoFabricacaoAeronaveMaisAtual = 0, anoFabricacaoAeronaveMaisAntiga = 5000, anoAtual = 2021;
                
            double mediaIdadesAeronvaes = 0, mediaVoosAeronaves = 0, somatorioIdadeGeralAeronaves = 0, somaVoosAeronaves = 0;

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Cadastro de Aeronaves<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            do
            {
                Console.Write("\n\nDigite a quantidade de Aeronaves que a Companhia Aérea possui: ");
                quantidadeAeronavesCompanhia = int.Parse(Console.ReadLine());

            } while(quantidadeAeronavesCompanhia < 5);
            

            for(int i = 1; i <= quantidadeAeronavesCompanhia; i++)
            {
                Console.Write("\n\nDigite o modelo da Aeronave: ");
                modelo = Console.ReadLine();

                Console.Write("\n\nDigite o ano da fabricação da Aeronave: ");
                anoFabricacao = int.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o código da aeronave: ");
                codigoAeronave = Console.ReadLine();

                Console.Write("\n\nDigite a quantidade de vôos que Aeronave ja realizou: ");
                quantidadeVoosRealizado = int.Parse(Console.ReadLine());

               
                if (anoFabricacao > anoFabricacaoAeronaveMaisAtual)
                {
                    modeloAeronaveMaisAtual = modelo;
                    anoFabricacaoAeronaveMaisAtual = anoFabricacao;
                    codigoAeronaveMaisAtual = codigoAeronave;
                    quantidadeVoosAeronaveMaisAtual = quantidadeVoosRealizado;                                  
                }

                if (anoFabricacao < anoFabricacaoAeronaveMaisAntiga)
                {
                    modeloAeronaveMaisAntiga = modelo;
                    anoFabricacaoAeronaveMaisAntiga = anoFabricacao;
                    codigoAeronaveMaisAntiga = codigoAeronave;
                    quantidadeVoosAeronaveMaisAntiga = quantidadeVoosRealizado;
                }

                somaVoosAeronaves = somaVoosAeronaves + quantidadeVoosRealizado;
                somatorioIdadeGeralAeronaves = (anoAtual - anoFabricacao) + somatorioIdadeGeralAeronaves;
            }
           

            mediaIdadesAeronvaes = somatorioIdadeGeralAeronaves / quantidadeAeronavesCompanhia;
            mediaVoosAeronaves = somaVoosAeronaves / quantidadeAeronavesCompanhia;

            Console.Clear();
            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Relatórios Geral<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

         
            var companhia = new CompanhiaAerea();           
            companhia.NomeCompanhiaAerea = CadastroCompanhiaAerea.nomeCompanhiaAerea;
            companhia.AnoFundacao = CadastroCompanhiaAerea.anoFundacao;
            

            Console.WriteLine("\n\nCompanhia " + companhia.NomeCompanhiaAerea + "\nFundada em (" + companhia.AnoFundacao + ").");

            Console.WriteLine("\n\n\nA média das idades das aeronaves é: " + mediaIdadesAeronvaes);
            Console.WriteLine("\n\nA média dos vôos das aeronaves é: " + mediaVoosAeronaves);

            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Relatório Aeronave Mais Atual<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("\n\nCompanhia " + companhia.NomeCompanhiaAerea + "\nFundada em (" + companhia.AnoFundacao + ").");
            
            Console.WriteLine("\n\nModelo da Aeronvave: " + modeloAeronaveMaisAtual);
            Console.WriteLine("\nAno da Fabricação da Aeronave: " + anoFabricacaoAeronaveMaisAtual);
            Console.WriteLine("\nCódigo da Aeronave: " + codigoAeronaveMaisAtual);
            Console.WriteLine("\nQuantidade de vôos realizados pela Aeronave: " + quantidadeVoosAeronaveMaisAtual);

            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Relatório Aeronave Mais Antiga<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("\n\nCompanhia " + companhia.NomeCompanhiaAerea + "\nFundada em (" + companhia.AnoFundacao + ").");
            
            Console.WriteLine("\n\nModelo da Aeronave: " + modeloAeronaveMaisAntiga);
            Console.WriteLine("\nAno da Fabricação da Aeronave: " + anoFabricacaoAeronaveMaisAntiga);
            Console.WriteLine("\nCódigo da Aeronave: " + codigoAeronaveMaisAntiga);
            Console.WriteLine("\nQuantidade de vôos realizados pela Aeronave: " + quantidadeVoosAeronaveMaisAntiga);

            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");

        }
    }
}