using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class CalculoIntervaloSimples
    {
        public static void IntervaloSimples()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Determinar Intervalos<-------------------");
            int m1, m2, intervaloDeNumeros;

            Console.Write("\n\nDigite um número inteiro: ");
            m1 = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite um segundo número inteiro: ");
            m2 = int.Parse(Console.ReadLine());
            intervaloDeNumeros = m2;

            if (m2 <= m1)
            {
                Console.WriteLine("Segundo número digitado deve ser maior que o primeiro número informado!");
            }
            else
            {
                for (int i = m2; i > m1; i--)
                {
                    intervaloDeNumeros--;
                    Console.WriteLine("Número: " + intervaloDeNumeros);
                }
            }
        }
    }
}
