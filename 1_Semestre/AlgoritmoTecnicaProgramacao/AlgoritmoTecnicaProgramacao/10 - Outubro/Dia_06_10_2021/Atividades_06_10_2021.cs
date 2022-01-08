using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class Atividades_06_10_2021
    {
        public static void Aula_06_10_2021()
        {
            string opcao = "S";
                        
            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Realizados<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03\n4 - Exercicio_04 \n5 - Exercicio_05 \n6 - Exercicio_06 ");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                int operacao;
                operacao = int.Parse(Console.ReadLine());
                
                switch (operacao)
                {
                    case 1:
                        FatorialNumeroDigitado.Fatorial();
                        break;
                    case 2:
                        CalculoMediaTresNumeros.CalculoMediaBasico();
                        break;
                    case 3:
                        MediaNumeroDesejado.MediaAvancada();
                        break;
                    case 4:
                        CalculoIntervaloSimples.IntervaloSimples();
                        break;
                    case 5:
                        CalculoIntervalosAvancado.IntervaloAvancado();
                        break;
                    case 6:
                        CoordenadasCartesiana.ParesOrdenados();
                        break;
                    default:
                        Console.WriteLine("Opção digitada é invalida!");
                        break;
                }
                

                Console.Write("\n\nDeseja acessar outro exercício: ");               
                opcao = Console.ReadLine().ToUpper();

            } while(opcao != "N");                 
        }
    }
}
