using System;

namespace AlgoritmoTecnicaProgramacao
{
    public class Startup
    {
        public static void Inicio()
        {
            string opcao;
            int operacao;
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


            Console.WriteLine("\n1  - Aula_01\n2  - 25/08/2021\n3  - 15/09/2021\n4  - 18/09/2021\n5  - 22/09/2021\n6  - 06/10/2021" +
                "\n7  - 13/10/2021\n8  - Primeira Prova\n9  - 03/11/2021\n10 - 06/11/2021\n11 - 17/11/2021\n12 - 24/11/2021\n13 - 29/11/2021" +
                "\n14 - 01-12-2021\n15 - Trabalhando Com Matriz\n16 - Somando Linhas Matriz\n17 - Trabalhando Com Vetores" +
                "\n18 - Trabalhando Com Arquivos\n19 - Refatorando Vetores\n20 - Implementando Melhorias Vetores\n22 - Segunda Prova\n23 - Exercícios Toda Matéria");

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite Qual Aula Deseja Acessar: ");
            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                //case Aula_01:
                //    // code block
                //    break;
                case 2:
                    Dia_25_08_2021.Atividades_25_08_2021.Aula_25_08_2021();
                    break;
                case 3:
                    Dia_15_09_2021.Atividades_15_09_2021.Aula_15_09_2021();
                    break;
                case 4:
                    Dia_18_09_2021.Atividades_18_09_2021.Aula_18_09_2021();
                    break;
                case 5:
                    Dia_22_09_2021.Atividades_22_09_2021.Aula_22_09_2021();
                    break;
                case 6:
                    Dia_06_10_2021.Atividades_06_10_2021.Aula_06_10_2021();             
                    break;
                case 7:
                    Dia_13_10_2021.Atividades_13_10_2021.Aula_13_10_2021();
                    break;
                case 8:
                    Dia_19_10_2021.Prova_19_10_2021.Prova_1();
                    break;
                case 9:
                    Dia_03_11_2021.Dia_03_11_2021.ExercicioTrabalhandoOpcaoUsuario();
                    break;
                case 10:
                    Dia_06_11_2021.ProgramaEleitoral.SituacaoEleitoral();
                     break;
                case 11:
                    Dia_17_11_2021.MenuExercicios.AcessarMenuExercicios();
                    break;
                case 12:
                    Dia_24_11_2021.Exercicios_24_11_2021.AcessarExercicios_24_11_2021();
                    break;
                case 13:
                    Dia_29_11_2021.MegaSena.JogoMegaSena();
                    break;
                case 14:
                    Dia_01_12_2021.Matriz.AprendendoMatriz();
                    break;
                case 15:
                    Dia_01_12_2021.TrabalhandoComMatriz.TrabalhandoComElementosMatriz();
                    break;
                case 16:
                    Dia_01_12_2021.SomandoLinhasMatriz.SomandoLinhasMatrizGerandoVetor();
                    break;
                case 17:
                    Dia_06_12_2021.TrabalhandoComVetores.ManipulandoVetores();
                    break;
                case 18:
                    Dia_07_12_2021.TrabalhandoComArquivos.ManipulandoArquivos();
                    break;
                case 19:
                    Dia_08_12_2021.RefatorandoVetores.RefatorandoVetores_08_12_2021();
                    break;
                case 20:
                    //Dia_01_12_2021.TrabalhandoComMatriz.TrabalhandoComElementosMatriz();
                    break;
                case 21:
                    //Dia_01_12_2021.TrabalhandoComMatriz.TrabalhandoComElementosMatriz();
                    break;
                case 22:
                    Dia_15_12_2021.Prova.ProvaFinal();
                    break;
                case 23:
                    Exercicios_Diversos_Professor.Atividades_Professor.ExerciciosMateria();
                    break;
                default:
                    // code block
                    break;
            }
        }
    }
}

