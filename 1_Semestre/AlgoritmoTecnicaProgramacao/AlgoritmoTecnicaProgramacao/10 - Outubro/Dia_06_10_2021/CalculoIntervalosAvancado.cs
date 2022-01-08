using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class CalculoIntervalosAvancado
    {
        public static void IntervaloAvancado()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Determinar Soma e Média dos Números dos Intervalos<-------------------");
            int a, b, intervaloDeNumeros;
            double mediaNumerosDigitados = 0, somaNumerosDigitados = 0; ;

            Console.Write("\n\nDigite um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite um segundo número inteiro: ");
            b = int.Parse(Console.ReadLine());
            intervaloDeNumeros = b;

            if (b < a)
            {
                Console.WriteLine("Segundo número digitado deve ser maior que o primeiro número informado!");
            }
            else
            {
                for (int i = b; i > a; i--)
                {
                    intervaloDeNumeros--;
                    Console.WriteLine("Número: " + intervaloDeNumeros);
                    somaNumerosDigitados = somaNumerosDigitados + intervaloDeNumeros;
                    mediaNumerosDigitados = somaNumerosDigitados / (b - 1);
                }
            }
            Console.WriteLine("\n\nSoma dos números que estão entre : (" + a + ") e (" + b + ") é: " + somaNumerosDigitados);
            Console.WriteLine("\n\nMédia dos números que estão entre : (" + a + ") e (" + b + ") é: " + mediaNumerosDigitados);
        }
    }
}
