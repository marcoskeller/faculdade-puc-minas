using System;


namespace AlgoritmoTecnicaProgramacao.Dia_03_11_2021
{
    public class Dia_03_11_2021
    {
        /*
             * 1) Faça um procedimento chamado decisao que recebe como parâmetro um número inteiro positivo n (que deve estar entre 10 e 20) e um flag que indicará o que o procedimento deve fazer. Caso o flag seja igual a:
            1: o procedimento deve exibir os n primeiros números positivos ímpares;
            2: o procedimento deve exibir os n primeiros números positivos pares;
            3: o procedimento deve exibir a soma dos n primeiros números positivos ímpares (a soma deve ser calculada por uma função);
            4: o procedimento deve exibir a soma dos n primeiros números positivos pares (a soma deve ser calculada por uma função);
            qualquer outro valor: uma mensagem adequada deve ser exibida.

        */

        public static void ExercicioTrabalhandoOpcaoUsuario()
        {
            int opcao, numeroInformado;

            do
            {
                opcao = Decisao();

                switch (opcao)
                {
                    case 1:
                        numeroInformado = LerNumeroInteiroDigitado();
                        NumerosImPares(numeroInformado);
                        break;
                    case 2:
                        numeroInformado = LerNumeroInteiroDigitado();
                        NumerosPares(numeroInformado);
                        break;
                    case 3:
                        numeroInformado = LerNumeroInteiroDigitado();
                        Console.WriteLine("\n\nO resultado do somatório dos primeiros números ímpares é: " + SomaNumerosImpPares(numeroInformado));
                        Console.ReadKey();
                        break;
                    case 4:
                        numeroInformado = LerNumeroInteiroDigitado();
                        Console.WriteLine("\n\nO resultado do somatório dos primeiros números ímpares é: " + SomaNumerosPares(numeroInformado));
                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\n\nO valor informado é inválido.");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 5);
        }

        static int Decisao()
        {
            int opcao;

            Console.Clear();
            Console.WriteLine("\n\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.Write("\n1 - Primeiros números positivos ímpares");
            Console.Write("\n2 - Primeiros números positivos pares");
            Console.Write("\n3 - Soma dos n primeiros números positivos ímpares");
            Console.Write("\n4 - Soma dos n primeiros números positivos pares");
            Console.Write("\n5 - Sair");
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>MENU<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            opcao = LerNumeroInteiroOpcao("\n\nDigite a opçao desejada: ");

            return (opcao);
        }

        static int LerNumeroInteiroDigitado()
        {
            int numeroDigitado;
            bool resultado = false;

            do
            {
                Console.Write("\n\nDigite um número inteiro entre 10 e 20: ");
                numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado >= 10 && numeroDigitado <= 20)
                {
                    resultado = true;
                }

            } while (resultado != true);

            return (numeroDigitado);
        }

        static int LerNumeroInteiroOpcao(string mensagem)
        {
            int opcao;

            Console.Write(mensagem);
            opcao = int.Parse(Console.ReadLine());

            return (opcao);
        }

        static void NumerosPares(int numeroInformado)
        {

            for (var i = numeroInformado; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    numeroInformado = i;
                    Console.Write("\nOs numeros Pares são: " + numeroInformado);

                }
                //else
                //{
                //    numeroInformado = i;
                //    Console.Write("\nOs numeros Impares são: " + numeroInformado);
                //}
            }

            Console.ReadKey();
        }

        static void NumerosImPares(int numeroInformado)
        {
            for (var i = numeroInformado; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    numeroInformado = i;
                    //Console.Write("\nOs numeros Pares são: " + numeroInformado);

                }
                else
                {
                    numeroInformado = i;
                    Console.Write("\nOs numeros Impares são: " + numeroInformado);
                }
            }

            Console.ReadKey();
        }

        static int SomaNumerosPares(int numeroInformado)
        {
            int somaNumerosPares = 0;
            Console.WriteLine("\n");

            for (var i = numeroInformado; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    numeroInformado = i;
                    Console.Write("{0} , ", i);
                    somaNumerosPares = somaNumerosPares + i;
                }
                else
                {
                    numeroInformado = i;
                }
            }

            return somaNumerosPares;
        }

        static int SomaNumerosImpPares(int numeroInformado)
        {
            int somaNumerosImpares = 0;
            Console.WriteLine("\n");

            for (var i = numeroInformado; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    numeroInformado = i;
                }
                else
                {
                    numeroInformado = i;
                    somaNumerosImpares = somaNumerosImpares + i;
                    Console.Write("{0} , ", i);
                }
            }

            return somaNumerosImpares;
        }
    }
}
