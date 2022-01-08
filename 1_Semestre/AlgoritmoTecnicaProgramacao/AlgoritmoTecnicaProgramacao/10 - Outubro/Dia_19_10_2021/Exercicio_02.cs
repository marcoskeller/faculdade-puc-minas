using System;


namespace AlgoritmoTecnicaProgramacao.Dia_19_10_2021
{
    public class Exercicio_02
    {
        public static void Exercicio_02_Prova()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calculos Basicos<-------------------");

            int numeroA, numeroB, numeroC, media = 0, soma = 0, quantidadeNumeros = 0, primeiroNumero = 0, numeroMaiorMediaCalculada = 0;
            double mediaMaiorTerceiroNumero = 0;

            Console.Write("\nDigite o primeiro número inteiro positivo: ");
            numeroA = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número inteiro positivo: ");
            numeroB = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o terceiro número inteiro positivo: ");
            numeroC = int.Parse(Console.ReadLine());

            primeiroNumero = numeroA;

            for (int i = numeroA; i <= numeroB; i++)
            {
                if(i > numeroC)
                {
                    quantidadeNumeros = quantidadeNumeros + 1;
                    soma = soma + i;
                }                                                                                  
            }

            if (quantidadeNumeros > 0)
            {
                media = soma / quantidadeNumeros;
            }
            else
            {
                Console.WriteLine("\nA quantidade de números entre (" + primeiroNumero + ") e o número (" + numeroB + ") é: 0");
            }

            Console.Write("\n\nA soma dos números entre (" + primeiroNumero + ")" + " e o número (" + numeroB + ") é: " + soma);
            Console.Write("\n\nA quantidade de números entre (" + primeiroNumero + ")" + " e o número (" + numeroB + ") é: " + quantidadeNumeros);
            Console.Write("\n\nA média dos números entre (" + primeiroNumero + ")" + " e o número (" + numeroB + ") é: " + media + "\n\n");


            for(int a = numeroA; a <= numeroB; a++)
            {
                if (a > media)
                {
                    numeroMaiorMediaCalculada = a;                  
                    Console.Write("\nO(s) número(s)  entre (" + primeiroNumero + ")" + " e o número (" + numeroB + ")  que são maiores que a média calculada é: " + numeroMaiorMediaCalculada);
                }
            }                   
        }
    }
}