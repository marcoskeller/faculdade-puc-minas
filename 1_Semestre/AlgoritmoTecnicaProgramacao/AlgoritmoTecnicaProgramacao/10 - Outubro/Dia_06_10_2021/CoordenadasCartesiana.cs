using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class CoordenadasCartesiana
    {
        public static void ParesOrdenados()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Determinar Pares Ordenados<-------------------");
            int x, intervaloDeNumeros, resultado;

            Console.Write("\n\nDigite um número inteiro: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                resultado = x - 1;
                Console.WriteLine("\n\nPares Ordenados " + "(" + i + "),(" + resultado + ")");
            }
        }
    }
}
