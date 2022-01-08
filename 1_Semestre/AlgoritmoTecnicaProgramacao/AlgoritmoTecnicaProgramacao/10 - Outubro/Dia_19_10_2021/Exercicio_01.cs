using System;


namespace AlgoritmoTecnicaProgramacao.Dia_19_10_2021
{ 
    public class Exercicio_01
    {
        public static void Exercicio_01_Prova()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Determinar Pares Ordenados<-------------------");

            int numeroA, numeroB, x, y;

            Console.Write("Digite o primeiro Número Inteiro: ");
            numeroA = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo Número Inteiro: ");
            numeroB = int.Parse(Console.ReadLine());

            for (x = 1; x <= numeroA; x++)
            {
                for (y = 1; y <= numeroB; y++)
                {
                    //Console.WriteLine("({0},{1}): Pares Ordenados", x, y);

                    if (x == (y * 3))
                    {
                        Console.WriteLine("\n\n({0},{1}): Pares Ordenados onde (" + x + ") é o triplo de (" + y + ")", x, y);
                    }
                }
            }                    
        }       
    }
}
