using System;


namespace AlgoritmoTecnicaProgramacao.Dia_13_10_2021
{
    public class Atividades_13_10_2021
    {
        public static void Aula_13_10_2021()
        {
            string opcao = "S";

            do
            {
                Console.Clear();
                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios Dia 13/10/2021<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                Console.WriteLine("\n\n1 - Exercicio_01\n2 - Exercicio_02\n3 - Exercicio_03\n4 - Exercicio_04 \n5 - Exercicio_05 \n6 - Exercicio_06" +
                    "\n7 - Exercicio_07\n8 - Exercicio_08\n9 - Exercicio_09\n10 - Exercicio_10\n11 - Exercicio_11\n12 - Exercicio_12" +
                    "\n13 - Exercicio_13\n14 - Exercicio_14");

                Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                Console.Write("\n\nDigite qual exercício deseja  executar: ");


                int operacao;
                operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Exercicio_01();
                        break;
                    case 2:
                        Exercicio_02();
                        break;
                    case 3:
                        Exercicio_03();
                        break;
                    case 4:
                        Exercicio_04();
                        break;
                    case 5:
                        Exercicio_05();
                        break;
                    case 6:
                        Exercicio_06();
                        break;
                    case 7:
                        Exercicio_07();
                        break;
                    case 8:
                        Exercicio_08();
                        break;
                    case 9:
                        Exercicio_09();
                        break;
                    case 10:
                        Exercicio_10();
                        break;
                    case 11:
                        Exercicio_11();
                        break;
                    case 12:
                        Exercicio_12();
                        break;
                    case 13:
                        Exercicio_13();
                        break;
                    case 14:
                        Exercicio_14();
                        break;
                    default:
                        break;
                }

                Console.Write("\n\nDeseja acessar outro exercício: ");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao != "N");

        }

        public static void Exercicio_01()
        {
            /*
             * 1) Faça programas em C# que:
                    a) escreva todos os n primeiros números inteiros positivos pares;
                    b) escreva todos os n primeiros números inteiros positivos ímpares.
                    O valor de n deve ser solicitado ao usuário.
             */
            int numerosPares = 0, numerosImpares = 0, numero;

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios 1<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.Write("\n\nDigite o número que será o limite: ");
            numero = int.Parse(Console.ReadLine());

            for (var i = numero; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    numerosPares = i;
                    Console.Write("\nOs numeros Pares são: " + numerosPares);

                }
                else
                {
                    numerosImpares = i;
                    Console.Write("\nOs numeros Impares são: " + numerosImpares);
                }
            }
        }

        public static void Exercicio_02()
        {
            /*
             * 2) Construa um algoritmo em C# que leia um número inteiro e determine se é um número par ou ímpar. 
             *    O número deve ser lido continuamente até que a quantidade de números pares ou a quantidade de números ímpares seja igual a 5.
             */
            int numero, quantidadePar = 0, quantidadeImpar = 0;

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios 2<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            do
            {
                Console.Write("\n\nDigite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.Write("\nO numero (" + numero + ") é Par.");
                    quantidadePar = quantidadePar + 1;
                }
                else
                {
                    Console.Write("\nO numero (" + numero + ") é Impar.");
                    quantidadeImpar = quantidadeImpar + 1;
                }

            } while (quantidadePar < 5 && quantidadeImpar < 5);

        }

        public static void Exercicio_03()
        {
            /*
             * 3) Construa um algoritmo em C# que leia um número inteiro e determine se é um número par ou ímpar. 
             *    O número deve ser lido continuamente até que a quantidade de números pares seja o dobro da quantidade de números ímpares.
             */

            int numero, quantidade = 0, quantidadePar = 0, quantidadeImpar = 0;

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios 3<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            do
            {
                Console.Write("\n\nDigite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.Write("\nO numero (" + numero + ") é Par.");
                    quantidadePar = quantidadePar + 1;
                }
                else
                {
                    Console.Write("\nO numero (" + numero + ") é Impar.");
                    quantidadeImpar = quantidadeImpar + 1;
                }

                if ((quantidadePar / quantidadeImpar) == 0)
                {
                    quantidade = 5;
                    Console.Write("\nQuantidade é :" + quantidade);
                }
                else
                {
                    quantidade = quantidade;
                }

            } while (quantidade != 5);

        }

        public static void Exercicio_04()
        {
            /*
             * 4) Faça um algoritmo em C# que:
                    a) leia o número de sets vencidos por duas equipes em uma partida de vôlei;
                    b) determine qual foi a equipe que venceu a partida.
                    O processo deve se repetir enquanto a vitória de uma das duas equipes não for por 3 sets a 0. 
                  Além disso, deve ser feita a validação dos dados informados pelo usuário. 
                  Enquanto os valores informados não forem válidos, devem ser lidos novamente.
             */

            int quantidadeVitorias = 0, setsEquipeA = 0, setsEquipeB = 0, resultado = 0;

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercícios 4<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            do
            {
                Console.Write("\n\nDigite a quantidade de Sets vencidos pela Equipe (A): ");
                setsEquipeA = int.Parse(Console.ReadLine());

                Console.Write("\n\nDigite a quantidade de Sets vencidos pela Equipe (B): ");
                setsEquipeB = int.Parse(Console.ReadLine());

                if (setsEquipeA >= 0 && setsEquipeA <= 3 && setsEquipeB >= 0 && setsEquipeB <= 3)
                {
                    if (setsEquipeA > setsEquipeB)
                    {
                        Console.Write("\nA equipe vencedora foi a \nEquipe (A) por: \n(" + setsEquipeA + ") a (" + setsEquipeB + ")");
                        //quantidadePar = quantidadePar + 1;
                    }
                    else if (setsEquipeB > setsEquipeA)
                    {
                        Console.Write("\nA equipe vencedora foi a \nEquipe (B) por: \n(" + setsEquipeB + ") a (" + setsEquipeA + ")");
                        //quantidadeImpar = quantidadeImpar + 1;
                    }
                    else
                    {
                        Console.Write("\nNão houve vencedores! \nSets das Equipes: \n(" + setsEquipeA + ") a (" + setsEquipeB + ")");
                    }

                    if (setsEquipeA == 3 && setsEquipeB == 0)
                    {
                        resultado = 1;
                    }
                    else if (setsEquipeB == 3 && setsEquipeA == 0)
                    {
                        resultado = 1;
                    }
                    else
                    {
                        resultado = resultado;
                    }
                }
                else
                {
                    Console.WriteLine("\n\nValores digitados são inválidos.\n\nFavor digitar valores válidos!");
                }

            } while (resultado != 1);
        }

        public static void Exercicio_05()
        {
            /*
             * 5) Um terminal de caixa eletrônico de um banco disponibiliza para os clientes as seguintes opções:
                    a) Saque
                    b) Depósito
                    c) Pagamento de Conta
                    d) Transferência
                    e) Sair
                    Faça um algoritmo em C# que:
                    a) leia o saldo atual da conta corrente do cliente;
                    b) leia a operação desejada pelo usuário, conforme a numeração acima (enquanto a opção Sair não tiver sido escolhida isso deve ser repetido);
                    c) leia o valor da operação a ser realizada;
                    d) calcule e escreva o saldo final da conta.
             */



            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Conta Bancária<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            Console.WriteLine("\n\n1 - Saque\n2 - Depósito\n3 - Pagamento de Conta\n4 - Transferência");


            int operacaoBancaria;
            Console.Write("\n\nDigite a operação desejada: ");
            operacaoBancaria = int.Parse(Console.ReadLine());

            switch (operacaoBancaria)
            {
                case 1:
                    Saque();
                    break;
                case 2:
                    Deposito();
                    break;
                case 3:
                    PagamentoConta();
                    break;
                case 4:
                    Transferencia();
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }


            static void Saque()
            {
                double saque, saldoAtualizado, saldoAtual;

                Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
                saldoAtual = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor que deseja sacar: R$");
                saque = double.Parse(Console.ReadLine());

                if (saque > saldoAtual)
                {
                    Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
                }
                else
                {
                    saldoAtualizado = saldoAtual - saque;
                    Console.WriteLine("\n\nRelatório Atualizado!");
                    Console.WriteLine("\nValor a Sacar: R$" + saque);
                    Console.WriteLine("\nSaldo Atualizado Após o Saque: R$" + saldoAtualizado);
                }
            }

            static void Deposito()
            {
                double deposito, saldoAtualizado = 0, saldoAtual, saldo = 0;

                Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
                saldoAtual = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o valor que deseja depositar: R$");
                deposito = double.Parse(Console.ReadLine());

                saldoAtualizado = saldoAtual + deposito;

                Console.WriteLine("\n\nRelatório Atualizado!");
                Console.WriteLine("\nValor a Depositar: R$" + deposito);
                Console.WriteLine("\nSaldo Atualizado Após o Depósito: R$" + saldoAtualizado);
            }

            static void PagamentoConta()
            {
                double pagamentoConta, saldoAtualizado, saldoAtual;

                Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
                saldoAtual = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o valor da conta que irá pagar: R$");
                pagamentoConta = double.Parse(Console.ReadLine());

                if (pagamentoConta > saldoAtual)
                {
                    Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
                }
                else
                {
                    saldoAtualizado = saldoAtual - pagamentoConta;
                    Console.WriteLine("\n\nRelatório Atualizado!");
                    Console.WriteLine("\nValor da Conta a Pagar: R$" + pagamentoConta);
                    Console.WriteLine("\nSaldo Atualizado Após o Pagamento da Conta: R$" + saldoAtualizado);
                }
            }

            static void Transferencia()
            {
                double transferencia, saldoAtualizado, saldoAtual;

                Console.Write("\n\nDigite o saldo atual da sua Conta: R$");
                saldoAtual = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o valor que irá transferir: R$");
                transferencia = double.Parse(Console.ReadLine());

                if (transferencia > saldoAtual)
                {
                    Console.WriteLine("\n\nOperação não pode ser realizada!\n\nSaldo Indisponível!");
                }
                else
                {
                    saldoAtualizado = saldoAtual - transferencia;
                    Console.WriteLine("\n\nRelatório Atualizado!");
                    Console.WriteLine("\nValor da Transferência a Realizar: R$" + transferencia);
                    Console.WriteLine("\nSaldo Atualizado Após a Transferência do dinheiro: R$" + saldoAtualizado);
                }
            }
        }

        public static void Exercicio_06()
        {
            /*
             * 6) Faça um algoritmo em C# que leia os coeficientes de uma equação do segundo grau (a, b e c). 
             *    Enquanto o valor do delta não for positivo, deve-se ler novamente os coeficientes. 
             *    Em seguida, deve-se calcular e exibir as raízes da equação. 
             */

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calcular a Equação de Segundo Grau<-------------------");
            double numeroA, numeroB, numeroC, delta, raiz1, raiz2;

            do
            {
                Console.Write("\n\nDigite o valor para A: ");
                numeroA = double.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o valor para B: ");
                numeroB = double.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o valor para C: ");
                numeroC = double.Parse(Console.ReadLine());

                delta = (numeroB * numeroB) - (4 * numeroA * numeroC);

            } while (delta < 0);


            raiz1 = ((-numeroB) + (Math.Sqrt(delta))) / 2;
            raiz2 = ((-numeroB) - (Math.Sqrt(delta))) / 2;

            Console.WriteLine("\n\nA primeira raiz é: " + raiz1);
            Console.WriteLine("\n\nA segunda raiz é: " + raiz2);

        }

        public static void Exercicio_07()
        {
            /*
             * 7) A série de Fibonacci é formada pelos números abaixo:
                    1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
                    Os dois primeiros termos da série são iguais a 1 e do terceiro em diante cada termo é igual à soma dos dois anteriores. 
                    Faça um algoritmo em C# que leia um número inteiro n e escreva os n primeiros termos da sequência de Fibonacci.
f
             */
           
            

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercício Sequência de Fibonacci<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int numero, sequenciaFibonacci = 1, auxiliarFibonacci1, auxiliar2 = 1;
            int fibonacci = 1, auxiliar = 1, a = 1;

            Console.Write("\n\nDigite o número que será o limite: ");
            numero = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < numero; i++)
            {
                auxiliarFibonacci1 = sequenciaFibonacci;
                sequenciaFibonacci = auxiliar2;
                auxiliar2 = sequenciaFibonacci + auxiliarFibonacci1;

                //2 Modo
                fibonacci = auxiliar;
                auxiliar = a;
                a = auxiliar + fibonacci;
          
                //Console.WriteLine(i + 1 + "º = " + auxiliarFibonacci1);

                Console.WriteLine(i + 1 + "º = " + fibonacci);

            }                       
        }

        public static void Exercicio_08()
        {
            /*
             * 8) Faça um algoritmo em C# que:
                    a) leia o nome e o número de votos de dois candidatos em uma eleição;
                    b) determine qual candidato foi o vencedor ou se houve empate (em caso de empate, 
                       mostrar mensagem de que nova eleição deve ser realizada e ler os números de votos novamente);
                    c) escreva o resultado.
             */

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Eleição Com Dois Candidatos<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            
            string candidatoA, candidatoB;
            int quantidadeVotosCandidatoA, quantidadeVotosCandidatoB, repetirEleicao;

            do
            {
                Console.Write("\n\nDigite o nome do Primeiro Candidato:  ");
                candidatoA = Console.ReadLine();

                Console.Write("\n\nDigite a quantidade de Votos do Candidato (" + candidatoA + ") : ");
                quantidadeVotosCandidatoA = int.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o nome do Segundo Candidato:  ");
                candidatoB = Console.ReadLine();

                Console.Write("\n\nDigite a quantidade de Votos do Candidato (" + candidatoB + ") : ");
                quantidadeVotosCandidatoB = int.Parse(Console.ReadLine());


                if(quantidadeVotosCandidatoA > quantidadeVotosCandidatoB)
                {
                    Console.WriteLine("\nCandidato (" + candidatoA + ") foi o vencedor da eleição!");
                    repetirEleicao = 0;
                }
                else if(quantidadeVotosCandidatoB > quantidadeVotosCandidatoA)
                {
                    Console.WriteLine("\nCandidato (" + candidatoB + ") foi o vencedor da eleição!");
                    repetirEleicao = 0;
                }
                else
                {
                    Console.WriteLine("\nHouve Empate de Votos!Será necessário uma nova eleição!");
                    Console.WriteLine("\nDigite novamente os dados dos Candidatos!");
                    repetirEleicao = 1;
                }               

            } while(repetirEleicao != 0);
        }
    

        public static void Exercicio_09()
        {
            /*
             * 9) Escreva um algoritmo em C# que
                    a) leia a idade de n pessoas;
                    b) para cada uma delas, calcule e escreva o tipo de eleitor segundo os critérios abaixo:
                      i) menor de 16 anos: não eleitor;
                      ii) de 16 a 17 anos, ou mais de 69 anos: eleitor facultativo;
                      iii) de 18 a 69 anos: eleitor obrigatório.
                  O valor de n deve ser informado pelo usuário e deve ser um valor positivo. 
                  Deve ser feita a validação dos dados informados pelo usuário. 
                  Enquanto os valores informados não forem válidos, devem ser lidos novamente.
             */

            Console.Clear();
            Console.WriteLine("\n\n-------->Tipo de Eleitor<-------------------");
            
            int idadeEleitor = 0, digitarNovamente = 0;
            string nomeEleitor;

            do
            {
                Console.Write("\n\nDigite o nome de quem deseja se cadastrar: ");
                nomeEleitor = Console.ReadLine();

                Console.Write("\n\nDigite a idade da pessoa que deseja se cadastrar: ");
                idadeEleitor = int.Parse(Console.ReadLine());

                if (idadeEleitor < 0)
                {
                    Console.WriteLine("\n\nIdade digitada é inválida.\n\n\nFavor digitar os dados novamente!");
                    digitarNovamente = -1;
                }
                else if (idadeEleitor < 16)
                {
                    Console.Write("\n\n" + nomeEleitor + ": Não pode votar porque tem menos de 16 anos de idade!");
                    digitarNovamente = 1;
                }
                else if (idadeEleitor >= 16 && idadeEleitor <= 17 || idadeEleitor >= 69)
                {
                    Console.Write("\n\n" + nomeEleitor + ": Pode votar mas não é obrigatório!");
                    digitarNovamente = 1;
                }
                else
                {
                    Console.Write("\n\n" + nomeEleitor + ": Votar é obrigatório!");
                    digitarNovamente = 1;
                }
            } while(digitarNovamente < 0);
            
        }

        public static void Exercicio_10()
        {
            /*
             * 10) Faça um algoritmo em C# que leia n números inteiros e calcule a sua soma. 
             *     O valor de n deve ser informado pelo usuário e o programa deve validar o valor de n para que seja pelo menos igual a 5.
             */

            Console.Clear();
            Console.WriteLine("\n\n-------->Somatório de Números<-------------------");

            int quantidadeNumerosSomados = 0, somatorio = 0, numero = 0, validaQuantidadeNumero = 0;
            string nomeEleitor;

            do
            {               
                Console.Write("\n\nDigite quantos números serão somados: ");
                quantidadeNumerosSomados = int.Parse(Console.ReadLine());

                if (quantidadeNumerosSomados >= 5)
                {
                    Console.Clear();

                    for (int i = 0; i < quantidadeNumerosSomados; i++)
                    {
                        Console.Write("\n\nDigite um número inteiro para ser somado: ");
                        numero = int.Parse(Console.ReadLine());

                        somatorio = somatorio + numero;
                    }

                    Console.WriteLine("\n\nO somatório dos números digitados é: " + somatorio);
                    validaQuantidadeNumero = 0;
                }
                else
                {
                    Console.WriteLine("\n\nA quantidade de números para o somatório deve ser igual ou superior a 5." + "\n\nDigite a quantidade de números novamente!");
                    validaQuantidadeNumero = 1;
                }

            }while(validaQuantidadeNumero != 0);
                      
        }

        public static void Exercicio_11()
        {
            /*
             * 11) Faça um algoritmo em C# que leia n números inteiros e calcule o seu produto.  
             *     O valor de n deve ser informado pelo usuário e o programa deve validar o valor de n para que seja pelo menos igual a 5.
             */

            Console.Clear();
            Console.WriteLine("\n\n-------->Produto dos Números Digitados<-------------------");

            int quantidadeNumerosMultiplicados = 0, produto = 1, numero = 0, validaQuantidadeNumero = 0;
            string nomeEleitor;

            do
            {
                Console.Write("\n\nDigite quantos números serão calculados: ");
                quantidadeNumerosMultiplicados = int.Parse(Console.ReadLine());

                if (quantidadeNumerosMultiplicados >= 5)
                {
                    Console.Clear();

                    for (int i = 0; i < quantidadeNumerosMultiplicados; i++)
                    {
                        Console.Write("\n\nDigite um número inteiro para ser calculado seu produto: ");
                        numero = int.Parse(Console.ReadLine());

                        produto = produto * numero;
                    }

                    Console.WriteLine("\n\nO produto dos números digitados é: " + produto);
                    validaQuantidadeNumero = 0;
                }
                else
                {
                    Console.WriteLine("\n\nA quantidade de números para o calculo do produto deve ser igual ou superior a 5." + "\n\nDigite a quantidade de números novamente!");
                    validaQuantidadeNumero = 1;
                }

            } while (validaQuantidadeNumero != 0);

        }

        public static void Exercicio_12()
        {
            /*
             * 12) Teobaldo e Astrogildo estão disputando a eleição para prefeito na cidade de Fim do Mundo do Norte. Faça um programa em C# que:
                    a) leia um número inteiro n correspondente a um número de eleitores 
                       (o programa deve insistir com o usuário até que o valor de n seja maior ou igual a 10);
                    b) leia o número de cada um dos candidatos que concorrem ao cargo de prefeito;
                    c) leia o voto de cada um dos n eleitores, que pode ser em um dos candidatos, nulo ou branco 
                       (0 é voto em branco e qualquer outro valor além dos números dos candidatos é voto nulo);
                    d) determine e mostre o resultado da eleição.
             */


            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Eleição Com Determinado Números de Eleitor<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            string candidatoA, candidatoB, relatorioEleicao="", realizarEleicaoNovamente = "S";
            int quantidadeVotosCandidatoA = 0, quantidadeVotosCandidatoB = 0, repetirEleicao = 0, numeroCandidatoA, numeroCandidatoB, 
                quantidadeVotosNulo = 0, quantidadeVotosBranco = 0, quantidadeEleitores = 0, validaQuantidadeEleitores = 0, votoEleitor = 0;

            do
            {
                do
                {
                    Console.Write("\n\n\nDigite a quantidade de eleitores que irão votar: ");
                    quantidadeEleitores = int.Parse(Console.ReadLine());

                    if (quantidadeEleitores >= 10)
                    {
                        Console.Write("\n\nDigite o nome do Primeiro Candidato:  ");
                        candidatoA = Console.ReadLine();

                        Console.Write("\n\nDigite o número do candidato (" + candidatoA + "): ");
                        numeroCandidatoA = int.Parse(Console.ReadLine());

                        Console.Write("\n\nDigite o nome do Segundo Candidato:  ");
                        candidatoB = Console.ReadLine();

                        Console.Write("\n\nDigite o número do candidato (" + candidatoB + "): ");
                        numeroCandidatoB = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nCandidato: " + candidatoA + "    Número = " + numeroCandidatoA +
                                          "\nCandidato: " + candidatoB + "    Número = " + numeroCandidatoB +
                                          "\nVoto em Branco" + "  Pressione = " + "0");



                        for (int i = 0; i < quantidadeEleitores; i++)
                        {
                            Console.Write("\n\nDigite seu voto:");
                            votoEleitor = int.Parse(Console.ReadLine());

                            if (votoEleitor == numeroCandidatoA)
                            {
                                quantidadeVotosCandidatoA = quantidadeVotosCandidatoA + 1;
                            }
                            else if (votoEleitor == numeroCandidatoB)
                            {
                                quantidadeVotosCandidatoB = quantidadeVotosCandidatoB + 1;
                            }
                            else if (votoEleitor == 0)
                            {
                                quantidadeVotosBranco = quantidadeVotosBranco + 1;
                            }
                            else
                            {
                                quantidadeVotosNulo = quantidadeVotosNulo + 1;
                            }
                        }

                        if (quantidadeVotosCandidatoA > quantidadeVotosCandidatoB && quantidadeVotosCandidatoA > quantidadeVotosBranco && quantidadeVotosCandidatoA > quantidadeVotosNulo)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\nO Candidato " + candidatoA + " foi o vencedor da eleição com (" + quantidadeVotosCandidatoA + ") votos.");
                            //relatorioEleicao = "\n\n\nO Candidato " + candidatoA + " foi o vencedor da eleito com (" + quantidadeVotosCandidatoA + ") votos.";
                        }
                        else if (quantidadeVotosCandidatoB > quantidadeVotosCandidatoA)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\nO Candidato " + candidatoB + " foi o vencedor da eleição com (" + quantidadeVotosCandidatoB + ") votos.");
                        }
                        else if (quantidadeVotosBranco > quantidadeVotosCandidatoA && quantidadeVotosBranco > quantidadeVotosCandidatoB && quantidadeVotosBranco > quantidadeVotosNulo)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\nNão houve ganhador pois o números de votos branco superaram os votos do candidatos!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\nNão houve ganhador pois o números de votos nulos superaram os votos do candidatos!");
                        }

                        //Console.Clear();
                        Console.WriteLine("\n\n\n>>>>>>>>>>>>>>>>>>>>>>>>Relatório da Eleição<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");


                        Console.WriteLine("\n\nCandidato: " + candidatoA);
                        Console.WriteLine("\n\nNúmeros de Votos Recebidos: " + quantidadeVotosCandidatoA);

                        Console.WriteLine("\n\nCandidato: " + candidatoB);
                        Console.WriteLine("\n\nNúmeros de Votos Recebidos: " + quantidadeVotosCandidatoB);

                        Console.WriteLine("\n\nQuantidade de Votos Branco: " + quantidadeVotosBranco);

                        Console.WriteLine("\n\nQuantidade de Votos Nulos: " + quantidadeVotosNulo);

                    }
                    else
                    {
                        Console.Write("\n\n\nA quantidade de eleitor deve ser maior ou igual a 10 pessoas.\n\n\nInforme novamente a quantidade de eleitores!");
                        validaQuantidadeEleitores = 1;
                    }

                    Console.Write("\n\n\nDeseja realizar novamente a eleição: ");
                    realizarEleicaoNovamente = Console.ReadLine().ToUpper();

                } while(realizarEleicaoNovamente != "N");
                              
            } while(quantidadeEleitores != 0);

        }

        public static void Exercicio_13()
        {
            /*
             * 13) O mesmo do exercício anterior, mas considerando que os votos serão lidos até que seja informado o valor -1.
             */

        }

        public static void Exercicio_14()
        {
            /*
             * 14) Faça um programa em C# que:
                    a) permita ao usuário informar dois números inteiros q1 e q2;
                    b) mostre na tela todos os pares ordenados formados com os números inteiros de 1 a q1 
                       e os os números inteiros de 1 a q2 de uma das três formas abaixo:
                    (a) (x, y): nesse par ordenado o primeiro elemento (x) é maior que o segundo (y);
                    (b) (x, y): nesse par ordenado o primeiro elemento (x) é menor que o segundo (y);
                    (c) (x, y): nesse par ordenado o primeiro e o segundo elementos (x e y) são iguais.
             */

        }




    }
}
