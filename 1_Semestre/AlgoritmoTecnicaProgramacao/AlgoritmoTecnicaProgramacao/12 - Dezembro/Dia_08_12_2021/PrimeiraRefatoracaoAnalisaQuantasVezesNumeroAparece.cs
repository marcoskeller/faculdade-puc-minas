using System;


namespace AlgoritmoTecnicaProgramacao.Dia_08_12_2021
{
    public class PrimeiraRefatoracaoAnalisaQuantasVezesNumeroAparece
    {
        public static void PrimeiraRefatoracaoAnalisaQuantasVezesNumeroApareceVetor()
        {
            int[] V = { 3, 17, 15, 3, 18, 3, 15 };

            Analise(V);
        }

        static int Contagem(int[] V, int x)
        {
            int i, cont = 0;

            for (i = 0; i < V.Length; i++)
                if (x == V[i])
                    cont++;

            return (cont);
        }

        static bool estaPresente(int[] V, int x, int pos)
        {
            int i;

            for (i = 0; i < pos; i++)
            {
                if (V[i] == x)
                    return true;
            }
            return false;

        }

        static void Analise(int[] V)
        {
            int i, pos = 0;
            int[] Analisados = new int[V.Length];

            for (i = 0; i < V.Length; i++)
                if (estaPresente(Analisados, V[i], pos) == false)
                {
                    Console.WriteLine($"O valor {V[i]} aparece {Contagem(V, V[i])} Vezes");
                    Analisados[pos] = V[i];
                    pos++;
                }

        }
    }
}
