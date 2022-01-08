using System;

namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class Calculadora
    {
        public static void CalculadoraBasica()
        {
            /*
            5) Faça um programa em C# que leia 4 números inteiros positivos e em seguida calcule:
            a) a soma dos números;
            b) a média;
            c) o maior;
            b) o menor;
            c) quantos são pares;
            d) quantos são ímpares.
            */

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calculadora Basica<-------------------");
            double numero1, numero2, numero3, numero4, somatorioNumeros, mediaNumeros, quantidadeNumerospares = 0 , 
                   quantidadeNumerosImpares = 0, maiorNumero, menorNumero;

            Console.Write("\n\nDigite o valor para o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para o terceiro número: ");
            numero3 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para o quarto número: ");
            numero4 = double.Parse(Console.ReadLine());

            somatorioNumeros = (numero1 + numero2 + numero3 + numero4);
            mediaNumeros = somatorioNumeros / 4;

            //Determinando Maior Numero
            if(numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
            {
                maiorNumero = numero1;
            }
            else if(numero2 > numero1 && numero2 > numero3  && numero2 > numero4)
            {
                maiorNumero = numero2;
            }
            else if(numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
            {
                maiorNumero = numero3;
            }
            else
            {
                maiorNumero = numero4;
            }

            //Determinando Menor Numero
            if (numero1 < numero2 && numero1 < numero3 && numero1 < numero4)
            {
                menorNumero = numero1;
            }
            else if (numero2 < numero1 && numero2 < numero3 && numero2 < numero4)
            {
                menorNumero = numero2;
            }
            else if (numero3 < numero1 && numero3 < numero2 && numero3 < numero4)
            {
                menorNumero = numero3;
            }
            else
            {
                menorNumero = numero4;
            }


            
            //Determinando Numeros Pares e Impares
            if (numero1 % 2 == 0)
            {
                quantidadeNumerospares += 1; 
            }
            else
            {
                quantidadeNumerosImpares += 1;
            }
            if (numero2 % 2 == 0)
            {
                quantidadeNumerospares += 1;
            }
            else
            {
                quantidadeNumerosImpares += 1;
            }
            if (numero3 % 2 == 0)
            {
                quantidadeNumerospares += 1;
            }
            else
            {
                quantidadeNumerosImpares += 1;
            }
            if (numero4 % 2 == 0)
            {
                quantidadeNumerospares += 1;
            }
            else
            {
                quantidadeNumerosImpares += 1;
            }

            Console.WriteLine("\n\nA soma dos números digitados é: " + somatorioNumeros);
            Console.WriteLine("\nA média dos números digitados é: " + mediaNumeros);
            Console.WriteLine("\nO maior número digitado é: " + maiorNumero);
            Console.WriteLine("\nO menor número digitado é: " + menorNumero);
            Console.WriteLine("\nO total de número pares digitados é: " + quantidadeNumerospares);
            Console.WriteLine("\nO total de numeros impares digitados é: " + quantidadeNumerosImpares);
        }
    }
}
