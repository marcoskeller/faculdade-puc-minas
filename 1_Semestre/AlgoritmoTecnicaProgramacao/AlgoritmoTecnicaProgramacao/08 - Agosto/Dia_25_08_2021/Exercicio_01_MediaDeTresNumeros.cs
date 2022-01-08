using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{ 
    public class Exercicio_01_MediaDeTresNumeros
    {
        /*
         * 1) Faça um algoritmo em Portugol que:
                a) leia três números reais (x, y e z);
                b) calcule a média aritmética M dos três valores;
                c) escreva os valores de x, y, z e M.

         */

        public static void MediaTresNumeros()
        {
            double numero1, numero2, numero3, mediaNumeros;
            
            Console.Write("\n\nDigite o valor do primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor do primeiro número: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor do primeiro número: ");
            numero3 = double.Parse(Console.ReadLine());

            mediaNumeros = (numero1 + numero2 + numero3) / 3;

            Console.WriteLine("\n\nPrimeiro Número Digitado: " + numero1);
            Console.WriteLine("\nSegundo Número Digitado: " + numero2);
            Console.WriteLine("\nTerceiro Número Digitado: " + numero3);
            Console.WriteLine("\nA média dos números digitado é: " + mediaNumeros);

        }
    }
}