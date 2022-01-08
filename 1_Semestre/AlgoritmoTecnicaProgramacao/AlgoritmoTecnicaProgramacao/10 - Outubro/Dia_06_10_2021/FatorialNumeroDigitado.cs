using System;



namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class FatorialNumeroDigitado 
    {

        public static void Fatorial()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Fatorial<-------------------");
            double numeroFatorial = 1, fatorial, resultado;
          
            Console.Write("\n\nDigite o valor do que deseja saber o fatorial: ");
            numeroFatorial = double.Parse(Console.ReadLine());

            fatorial = numeroFatorial;

            for (double i = numeroFatorial - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;
            }

            Console.WriteLine("\n\nO fatorial de " + numeroFatorial + " é: " + fatorial + "\n\n");
        }
        
    }

}

