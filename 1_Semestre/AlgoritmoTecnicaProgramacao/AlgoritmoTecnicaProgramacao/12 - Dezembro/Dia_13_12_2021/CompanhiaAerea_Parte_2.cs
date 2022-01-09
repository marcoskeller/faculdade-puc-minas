using System;
using System.IO;

namespace AlgoritmoTecnicaProgramacao.Dia_13_12_2021
{
    public class CompanhiaAerea_Parte_2
    {
        public static string caminho = "C:\\temp\\CompanhiaAerea\\",
                             nomeArquivoEntrada = "companhia_in.txt",
                             nomeArquivoSaida = "companhia_out.txt",
                             nomeCompanhia,
                             codigoAeronave,
                             modeloAeronave,
                             nomeCompanhiaAerea,
                             codigoAeronaveMaisAntiga = "",
                             codigoAeronaveMaisAtual = "",
                             modeloAeronaveMaisAntiga = "",
                             modeloAeronaveMaisAtual = "";

        public static int anoFundacaoCompanhia,
                          quantidadeAeronavesCompanhia = 0,
                          contadorGeral = 1,
                          quantidadeVoosRealizados = 0,
                          anoFabricacaoAeronave,
                          quantidadeVoosAeronaveMaisAntiga = 0,
                          quantidadeVoosAeronaveMaisAtual = 0,
                          anoFabricacaoAeronaveMaisAtual = 0,
                          anoFabricacaoAeronaveMaisAntiga = 5000,
                          anoAtual = 2021,
                          index = 1;

        public static double mediaIdadesAeronvaes = 0,
                             mediaVoosAeronaves = 0,
                             somatorioIdadeGeralAeronaves = 0,
                             somaVoosAeronaves = 0;

        public static string[] codigoAeronaves,
                               modeloAeronavesCompanhia;

        public static int[] dataFabricacaoAeronaves,
                            quantidadeVoosAeronaves;

        public static StreamReader arquivoEntrada = new StreamReader(caminho + nomeArquivoEntrada);
        public static StreamWriter arquivoSaida = new StreamWriter(caminho + nomeArquivoSaida, false);


        public static void CompanhiaAerea_2()
        {
            CadastrarCompanhiaAerea();
            Inicio();
        }

        public static void Inicio()
        {
            int operacao;


            Console.Clear();
            Console.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");
            Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.WriteLine("\n1  - Entrada de dados por Arquivo\n2  - Sair");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite Qual Funcionalidade Deseja Acessar: ");
            operacao = int.Parse(Console.ReadLine());


            switch (operacao)
            {
                case 1:
                    EntradaDadosAeronaves(quantidadeAeronavesCompanhia);
                    break;
                case 2:
                    SairPrograma();
                    break;
                default:
                    Console.WriteLine("Opção Inválida! Favor digitar um opção informada no Menu Inicial!");
                    break;
            }

            arquivoEntrada.Close();
            arquivoSaida.Close();


        }

        public static void LerArquivoTexto()
        {
            string linha;

            while (!arquivoEntrada.EndOfStream)
            {
                linha = arquivoEntrada.ReadLine();
                arquivoSaida.WriteLine($"Linha {contadorGeral} do arquivo de origem: {linha}");
                contadorGeral++;

            }
            quantidadeAeronavesCompanhia = int.Parse(arquivoEntrada.ReadLine());
        }

        public static void CadastrarCompanhiaAerea()
        {
            nomeCompanhiaAerea = arquivoEntrada.ReadLine();
            anoFundacaoCompanhia = int.Parse(arquivoEntrada.ReadLine());


            arquivoSaida.WriteLine($"\n\nCompanhia {nomeCompanhiaAerea}");
            arquivoSaida.WriteLine($"\nFundada em {anoFundacaoCompanhia}");


            Console.WriteLine("\n\n" + nomeCompanhiaAerea);
            Console.WriteLine("\n\n" + anoFundacaoCompanhia);

        }

        public static void EntradaDadosAeronaves(int quantidadeAeronaves)
        {
            string linha;

            do
            {
                linha = arquivoEntrada.ReadLine();
                quantidadeAeronavesCompanhia = int.Parse(linha);

            } while (quantidadeAeronavesCompanhia < 6);

            CriaVetores(quantidadeAeronavesCompanhia);
            RelatorioAeronaves(codigoAeronaves, dataFabricacaoAeronaves, quantidadeVoosAeronaves, modeloAeronavesCompanhia);
            RelatorioDadosAeronaves();
            AeronaveMaisAntiga(codigoAeronaves, dataFabricacaoAeronaves, quantidadeVoosAeronaves, modeloAeronavesCompanhia);
            AeronaveMaisAtual(codigoAeronaves, dataFabricacaoAeronaves, quantidadeVoosAeronaves, modeloAeronavesCompanhia);

        }

        static void CriaVetores(int tamanhoVetor)
        {
            string codigoAeronaveValidacao;

            codigoAeronaves = new string[tamanhoVetor];
            dataFabricacaoAeronaves = new int[tamanhoVetor];
            quantidadeVoosAeronaves = new int[tamanhoVetor];
            modeloAeronavesCompanhia = new string[tamanhoVetor];


            for (int i = 0; i < tamanhoVetor; i++)
            {
                do
                {
                    codigoAeronaveValidacao = arquivoEntrada.ReadLine();

                } while (ValidaCadastroAeronaveExistente(codigoAeronaveValidacao, codigoAeronaves));

                codigoAeronaves[i] = codigoAeronaveValidacao;
                dataFabricacaoAeronaves[i] = int.Parse(arquivoEntrada.ReadLine());
                quantidadeVoosAeronaves[i] = int.Parse(arquivoEntrada.ReadLine());
                modeloAeronavesCompanhia[i] = arquivoEntrada.ReadLine();
            }

        }

        static void RelatorioAeronaves(string[] vetorInformadoCodigo, int[] vetorInformadoAnoFabricacao, int[] vetorInformadoVoos, string[] vetorInformadoModelo)
        {
            Console.Clear();

            arquivoSaida.WriteLine("\n\n--------------------------------------------------Relatório Aeronaves------------------------------------------------------------");
            Console.WriteLine("\n\n--------------------------------------------------Relatório Aeronaves------------------------------------------------------------");

            arquivoSaida.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");
            Console.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");



            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {
                if (i == (vetorInformadoAnoFabricacao.Length - 1))
                {
                    arquivoSaida.WriteLine($"\n\n-->Dados da {i + 1}ª Aeronave\n");
                    arquivoSaida.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    arquivoSaida.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    arquivoSaida.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    arquivoSaida.WriteLine($"Modelo Aeronave: {vetorInformadoModelo[i]}");

                    Console.WriteLine($"\n\n-->Dados da {i + 1}ª Aeronave\n");
                    Console.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    Console.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    Console.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    Console.WriteLine($"Modelo: {vetorInformadoModelo[i]}");
                }
                else
                {
                    arquivoSaida.WriteLine($"\n\n-->Dados da {i + 1}ª Aeronave\n");
                    arquivoSaida.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    arquivoSaida.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    arquivoSaida.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    arquivoSaida.WriteLine($"Modelo: {vetorInformadoModelo[i]}");

                    Console.WriteLine($"\n\n-->Dados da {i + 1}ª Aeronave\n");
                    Console.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    Console.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    Console.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    Console.WriteLine($"Modelo: {vetorInformadoModelo[i]}");
                }
            }
            arquivoSaida.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
        }

        static double MediasVoos(int[] vetorInformado)
        {
            double mediaGeral = 0;
            int somatorio = 0;

            for (int i = 0; i < vetorInformado.Length; i++)
            {
                somatorio = somatorio + vetorInformado[i];
            }

            mediaGeral = somatorio / vetorInformado.Length;

            return Math.Round(mediaGeral, 2);
        }

        static double MediasDatasFabricacao(int[] vetorInformadoAnoFabricacao)
        {
            double mediaGeral = 0;
            int soma = 0;

            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {
                soma = soma + (anoAtual - vetorInformadoAnoFabricacao[i]);
            }

            mediaGeral = soma / vetorInformadoAnoFabricacao.Length;

            return Math.Round(mediaGeral, 2);
        }

        static void AeronaveMaisAntiga(string[] vetorInformadoCodigo, int[] vetorInformadoAnoFabricacao, int[] vetorInformadoVoos, string[] vetorInformadoModelo)
        {
            int anoFabricacao = vetorInformadoAnoFabricacao[0];
            int contador = 1;

            arquivoSaida.WriteLine("\n\n----------------------------------------------Relatório Aeronave(s) Mais Antiga(s)-------------------------------------------------");
            Console.WriteLine("\n\n----------------------------------------------Relatório Aeronave(s) Mais Antiga(s)-------------------------------------------------");

            arquivoSaida.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");
            Console.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");

            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {

                if (anoFabricacao > vetorInformadoAnoFabricacao[i])
                {
                    anoFabricacao = vetorInformadoAnoFabricacao[i];
                }
            }


            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {
                if (vetorInformadoAnoFabricacao[i] == anoFabricacao)
                {
                    arquivoSaida.WriteLine($"\n\n-->Dados da {contador}ª Aeronave\n");
                    arquivoSaida.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    arquivoSaida.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    arquivoSaida.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    arquivoSaida.WriteLine($"Modelo: {vetorInformadoModelo[i]}");

                    Console.WriteLine($"\n\n-->Dados da {contador}ª Aeronave\n");
                    Console.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    Console.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    Console.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    Console.WriteLine($"Modelo: {vetorInformadoModelo[i]}");

                    contador++;
                }
            }
            arquivoSaida.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
        }

        static void AeronaveMaisAtual(string[] vetorInformadoCodigo, int[] vetorInformadoAnoFabricacao, int[] vetorInformadoVoos, string[] vetorInformadoModelo)
        {
            int anoFabricacao = vetorInformadoAnoFabricacao[0];
            int contador = 1;

            arquivoSaida.WriteLine("\n\n----------------------------------------------Relatório Aeronave(s) Mais Atual-----------------------------------------------------");
            Console.WriteLine("\n\n----------------------------------------------Relatório Aeronave(s) Mais Atual-----------------------------------------------------");

            arquivoSaida.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");
            Console.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");

            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {

                if (anoFabricacao < vetorInformadoAnoFabricacao[i])
                {
                    anoFabricacao = vetorInformadoAnoFabricacao[i];
                }
            }


            for (int i = 0; i < vetorInformadoAnoFabricacao.Length; i++)
            {
                if (vetorInformadoAnoFabricacao[i] == anoFabricacao)
                {
                    arquivoSaida.WriteLine($"\n\n-->Dados da {contador}ª Aeronave\n");
                    arquivoSaida.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    arquivoSaida.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    arquivoSaida.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    arquivoSaida.WriteLine($"Modelo: {vetorInformadoModelo[i]}");

                    Console.WriteLine($"\n\n-->Dados da {contador}ª Aeronave\n");
                    Console.WriteLine($"Código: {vetorInformadoCodigo[i]}");
                    Console.WriteLine($"Ano de Fabricação: {vetorInformadoAnoFabricacao[i]}");
                    Console.WriteLine($"Quantidade Voo(s) Realizado(s): {vetorInformadoVoos[i]}");
                    Console.WriteLine($"Modelo: {vetorInformadoModelo[i]}");

                    contador++;
                }
            }
            arquivoSaida.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------\n\n\n");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------\n\n\n");
        }

        static void RelatorioDadosAeronaves()
        {
            arquivoSaida.WriteLine("\n\n-------------------------------------------Relatório de Dados das Aeronaves--------------------------------------------------------");
            Console.WriteLine("\n\n-------------------------------------------Relatório de Dados das Aeronaves--------------------------------------------------------");

            arquivoSaida.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");
            Console.WriteLine("\n\nCompanhia " + nomeCompanhiaAerea + "\nFundada em (" + anoFundacaoCompanhia + ").");


            arquivoSaida.WriteLine($"\nMédia dos voos realizados pelas Aeronaves é: {MediasVoos(quantidadeVoosAeronaves)}" + " voos.");
            Console.WriteLine($"\nMedia dos voos realizados pelas Aeronaves é: {MediasVoos(quantidadeVoosAeronaves)}" + " voos.");


            arquivoSaida.WriteLine($"\nMédia das idades das Aeronaves é: {MediasDatasFabricacao(dataFabricacaoAeronaves)}" + " anos.");
            Console.WriteLine($"\nMedia das idades das Aeronaves é: {MediasDatasFabricacao(dataFabricacaoAeronaves)}" + " anos.");

            arquivoSaida.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------------------------------------------------");
        }

        static bool ValidaCadastroAeronaveExistente(string codigoAeronaveValidacao, string[] vetorCodigoAeronave)
        {
            for (int i = 0; i < vetorCodigoAeronave.Length; i++)
            {
                if (codigoAeronaveValidacao == vetorCodigoAeronave[i])
                {
                    return true;
                }
            }
            return false;

        }

        static void SairPrograma()
        {
            Environment.Exit(0);
        }
    }
}
