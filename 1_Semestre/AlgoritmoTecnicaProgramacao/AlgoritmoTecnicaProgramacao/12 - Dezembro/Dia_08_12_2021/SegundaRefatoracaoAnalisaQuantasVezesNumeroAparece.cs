using System;


namespace AlgoritmoTecnicaProgramacao.Dia_08_12_2021
{
    public class SegundaRefatoracaoAnalisaQuantasVezesNumeroAparece
    {
        public static void SegundaRefatoracaoAnalisaQuantasVezesNumeroApareceVetor()
        {
            int q;
            int[] V;

            Console.Write("Tamanho do vetor: ");
            q = int.Parse(Console.ReadLine());

            V = CriaVetor(q);

            AnalisaParidade(V);
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
                if (!estaPresente(Analisados, V[i], pos))
                {
                    Console.WriteLine($"O valor {V[i]} aparece {Contagem(V, V[i])} Vezes");
                    Analisados[pos] = V[i];
                    pos++;
                }
        }

        static int[] CriaVetor(int q)
        {
            int[] V = new int[q];
            int i;

            Console.WriteLine("Informe os elementos do vetor: ");

            for (i = 1; i <= q; i++)
            {
                Console.Write($"{i}º elemento: ");
                V[i - 1] = int.Parse(Console.ReadLine());
            }

            return (V);
        }

        static void ExibeVetor(int[] V, int q, string msg)
        {
            int i;

            Console.WriteLine(msg);

            for (i = 0; i < q; i++)
                Console.Write($"{V[i]}, ");

            Console.WriteLine();
        }

        static void AnalisaParidade(int[] V)
        {
            int i, posP = 0, posI = 0;
            int[] VP = new int[V.Length], VI = new int[V.Length];

            for (i = 0; i < V.Length; i++)
                if (V[i] % 2 == 0)
                {
                    VP[posP] = V[i];
                    posP++;
                }
                else
                {
                    VI[posI] = V[i];
                    posI++;
                }

            ExibeVetor(V, V.Length, "Vetor geral");
            ExibeVetor(VP, posP, "Vetor de números pares");
            ExibeVetor(VI, posI, "Vetor de números ímpares");
        }
    }
}
