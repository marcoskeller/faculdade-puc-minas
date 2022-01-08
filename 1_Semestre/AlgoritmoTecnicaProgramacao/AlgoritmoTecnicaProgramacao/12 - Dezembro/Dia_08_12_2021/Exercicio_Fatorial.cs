using System;
using System.IO;

namespace AlgoritmoTecnicaProgramacao.Dia_08_12_2021
{
    public class Exercicio_Fatorial
    {
        public static void Fatorial()
        {
            StreamReader arq_in = new StreamReader("entrada.txt");
            StreamWriter arq_out = new StreamWriter("saida.txt", true);
            //string linha; // cada linha lida do arquivo de entrada
            int num;

            arq_out.WriteLine("Fatoriais:");
            Console.WriteLine("Fatoriais:");

            // enquanto não for fim de arquivo
            while (!arq_in.EndOfStream)
            {
                num = int.Parse(arq_in.ReadLine());
                arq_out.WriteLine($"{num}: {Fatorial(num)}");
                Console.WriteLine($"{num}: {Fatorial(num)}");
            }

            arq_in.Close();
            arq_out.Close();

            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();
        }

        static int Fatorial(int n)
        {
            int i, fat = 1;

            for (i = n; i >= 1; i--)
                fat = fat * i;

            return (fat);
        }
    }
}
