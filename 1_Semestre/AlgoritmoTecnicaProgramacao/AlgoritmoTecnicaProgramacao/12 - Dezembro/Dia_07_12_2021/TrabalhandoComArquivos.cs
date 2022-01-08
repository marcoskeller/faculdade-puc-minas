using System;
using System.IO;

namespace AlgoritmoTecnicaProgramacao.Dia_07_12_2021
{
    public class TrabalhandoComArquivos
    {
        public static string caminhoArquivo = "C:\\temp\\TrabalhandoComArquivos\\",
                             nomeArquivoEntrada = "companhia_in.txt",
                             nomeArquivoSaida = "companhia_out.txt",
                             nomeCompanhia,
                             codigoEquipamento,
                             modeloEquipamento;

        public static int anoFundacaoCompanhia,
                          anoFabricacaoEquipamento,
                          quantidadeEquipamento = 0,
                          quantidadeHoraUtilizadoEquipamento = 0;
                         
        public static StreamReader arquivoEntrada = new StreamReader(caminhoArquivo + nomeArquivoEntrada);
        public static StreamWriter arquivoSaida = new StreamWriter(caminhoArquivo + nomeArquivoSaida, false);

        
        public static void ManipulandoArquivos()
        {
            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Trabalhando Com Arquivos<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Companhia();
            Console.WriteLine($"\n\nCompanhia {nomeCompanhia}");
            Console.WriteLine($"\nFundada em {anoFundacaoCompanhia}");

            RelatorioEquipamentos();

            arquivoEntrada.Close();
            arquivoSaida.Close();

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<\n\n");
        }

        static void Companhia()
        {
            nomeCompanhia = arquivoEntrada.ReadLine();
            anoFundacaoCompanhia = int.Parse(arquivoEntrada.ReadLine());

            arquivoSaida.WriteLine($"\n\nCompanhia {nomeCompanhia}");
            arquivoSaida.WriteLine($"\nFundada em {anoFundacaoCompanhia}");
        }

        static void RelatorioEquipamentos()
        {
            do
            {
                quantidadeEquipamento = int.Parse(arquivoEntrada.ReadLine());
            }while(quantidadeEquipamento < 2);

            for(int i = 0; i < quantidadeEquipamento; i++)
            {
                codigoEquipamento = arquivoEntrada.ReadLine();
                anoFabricacaoEquipamento = int.Parse(arquivoEntrada.ReadLine());
                quantidadeHoraUtilizadoEquipamento = int.Parse(arquivoEntrada.ReadLine());
                modeloEquipamento = arquivoEntrada.ReadLine();

                Console.WriteLine("\n" + (i+1) + "º Equipamento");

                arquivoSaida.WriteLine($"\nCodigo do Equipamento: {codigoEquipamento}");
                arquivoSaida.WriteLine($"Ano de Fabricação do Equipamento: {anoFabricacaoEquipamento}");
                arquivoSaida.WriteLine($"Quantidade de horas utilizada no equipamento: {quantidadeHoraUtilizadoEquipamento}");
                arquivoSaida.WriteLine($"Modelo do Equipamento: {modeloEquipamento}");

                Console.WriteLine($"\nCodigo do Equipamento: {codigoEquipamento}");
                Console.WriteLine($"Ano de Fabricação do Equipamento: {anoFabricacaoEquipamento}");
                Console.WriteLine($"Quantidade de horas utilizada no equipamento: {quantidadeHoraUtilizadoEquipamento}");
                Console.WriteLine($"Modelo do Equipamento: {modeloEquipamento}");
            }

        }
    }
}
