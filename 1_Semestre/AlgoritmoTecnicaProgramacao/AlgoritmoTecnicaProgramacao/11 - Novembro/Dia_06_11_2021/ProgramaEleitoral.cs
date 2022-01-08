using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_11_2021
{
    public class ProgramaEleitoral
    {
        public static int idadeNaoEleitor = 0, idadeEleitorFacultaivo = 0, idadeEleitorObrigatorio = 0;
        public static double naoEleitor = 0, eleitorFacultativo = 0, eleitorObrigatorio = 0, mediaNaoEleitor, mediaEleitorFacultativo, mediaEleitorObrigatorio;

        public static void SituacaoEleitoral()
        {
            /*
                2) Faça um programa em C# que:
                a) solicite ao usuário que informe um número inteiro positivo n, correspondente a um número de pessoas;
                b) leia a idade e determine a situação eleitoral de cada uma das n pessoas;
                c) calcule a quantidade de pessoas e a média de idade de cada situação eleitoral.

                A situação eleitoral é definida conforme abaixo:
                a) de 0 a 15 anos: não eleitor;
                b) de 16 a 17 e acima de 70 anos: eleitor facultativo;
                c) de 18 a 70 anos: eleitor obrigatório.
            */
            int opcao, quantidadePessoas = 0, idades = 0;


            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        quantidadePessoas = LerQuantidadePessoas();
                        break;
                    case 2:
                        idades = SituacaoEleitoral(quantidadePessoas);
                        Console.ReadKey();
                        break;
                    case 3:
                        MediaIdadesSituacaoEleitoral();
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\n\nO valor informado é inválido.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 4);
        }

        static int Menu()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine("\n\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>Menu<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n\n1 - Informar quantidade de pessoas");
            Console.Write("\n2 - Verificar Situação Eleitoral");
            Console.Write("\n3 - Média das idades de cada situacao eleitoral");
            Console.Write("\n4 - Sair");
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            opcao = LerNumeroInteiroOpcao("\n\nDigite a opçao desejada: ");
            return (opcao);

        }

        static int LerNumeroInteiroOpcao(string mensagem)
        {
            int opcao;

            Console.Write(mensagem);
            opcao = int.Parse(Console.ReadLine());

            return (opcao);
        }

        static int LerQuantidadePessoas()
        {
            int quantidadePessoas = 0;
            bool resultado = false;

            do
            {
                Console.Write("\n\nDigite um número inteiro maior que 0: ");
                quantidadePessoas = int.Parse(Console.ReadLine());

                if (quantidadePessoas > 0)
                {
                    resultado = true;
                    Console.WriteLine("quantidade pessoas: " + quantidadePessoas);
                }

            } while (resultado == false);

            return quantidadePessoas;
        }

        static int SituacaoEleitoral(int quantidadePessoas)
        {
            int idade = 0;


            for (int i = quantidadePessoas; i > 0; i--)
            {
                Console.Write(i + "ª - Pessoa = Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 15)
                {
                    Console.WriteLine("Não Eleitor.");
                    naoEleitor = naoEleitor + 1;
                    idadeNaoEleitor = idadeNaoEleitor + idade;
                }
                else if (idade >= 16 && idade <= 17)
                {
                    Console.WriteLine("Eleitor Facultativo.");
                    eleitorFacultativo = eleitorFacultativo + 1;
                    idadeEleitorFacultaivo = idadeEleitorFacultaivo + idade;
                }
                else
                {
                    Console.WriteLine("Eleitor Obrigatório.");
                    eleitorObrigatorio = eleitorObrigatorio + 1;
                    idadeEleitorObrigatorio = idadeEleitorObrigatorio + idade;
                }

            }

            return idade;
        }

        static void MediaIdadesSituacaoEleitoral()
        {
            mediaNaoEleitor = 0;
            mediaEleitorFacultativo = 0;
            mediaEleitorObrigatorio = 0;

            mediaNaoEleitor = idadeNaoEleitor / naoEleitor;
            mediaEleitorFacultativo = idadeEleitorFacultaivo / eleitorFacultativo;
            mediaEleitorObrigatorio = idadeEleitorObrigatorio / eleitorObrigatorio;

            if (mediaNaoEleitor > 0)
            {
                Console.WriteLine("\n\nA média das idades das pessoas que não são eleitores é: " + mediaNaoEleitor);
            }
            else
            {
                Console.WriteLine("\n\nNão houve pessoas na Categoria de Não Eleitores.");
            }

            if (mediaEleitorFacultativo > 0)
            {
                Console.WriteLine("\n\nA média das idades dos Eleitores Facultativos é: " + mediaEleitorFacultativo);
            }
            else
            {
                Console.WriteLine("\n\nNão houve pessoas na Categoria de Eleitores Facultativos.");
            }

            if (mediaEleitorObrigatorio > 0)
            {
                Console.WriteLine("\n\nA média das idades dos Eleitores Obrigatórios é: " + mediaEleitorObrigatorio);
            }
            else
            {
                Console.WriteLine("\n\nNão houve pessoas na Categoria Eleitores Obrigatórios.");
            }

        }
    }
}
