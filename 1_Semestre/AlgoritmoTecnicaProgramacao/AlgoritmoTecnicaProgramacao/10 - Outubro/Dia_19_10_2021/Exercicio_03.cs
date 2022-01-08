using System;


namespace AlgoritmoTecnicaProgramacao.Dia_19_10_2021
{
    public class Exercicio_03
    {
        public static void Exercicio_03_Prova()
        {
            int tamanhoSequencia = 0, numeroA, numeroB, numeroC, somatorioSequencia = 0, antePenultimo = 0, penultimo = 0, ultimo = 0;

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Determinar Uma Sequencia<-------------------");

            do
            {
                Console.Write("\n\nDigite o tamanho da sequencia: ");
                tamanhoSequencia = int.Parse(Console.ReadLine());

            } while (tamanhoSequencia < 4);

            Console.Write("\nInforme o primeiro número da sequencia: ");
            antePenultimo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o segundo número da sequencia: ");
            penultimo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o terceiro número da sequencia: ");
            ultimo = int.Parse(Console.ReadLine());


            Console.WriteLine("\n\n\nA sequencia desejada é:");
            Console.Write("{0}, {1}, {2}, ", antePenultimo, penultimo, ultimo);

            for (int i = 4; i <= tamanhoSequencia; i++)
            {         
                somatorioSequencia = antePenultimo + penultimo + ultimo;
                antePenultimo = penultimo;
                penultimo = ultimo;
                ultimo = somatorioSequencia;
                                            
                Console.Write("{0}, ", somatorioSequencia);
           
            }
        }
    }
}
