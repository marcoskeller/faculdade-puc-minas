using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class CalculoRaizesEquacao
    {
        public static void EquacaoSegundoGrau()
        {
            //3) Escreva um algoritmo em C# que leia os coeficientes de uma equação do segundo grau. Em seguida, deve calcular e exibir (se existirem) as raízes da equação.

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calcuar a Equação de Segundo Grau<-------------------");
            double numeroA, numeroB, numeroC, delta, raiz1,raiz2;

            Console.Write("\n\nDigite o valor para A: ");
            numeroA = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para B: ");
            numeroB = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para C: ");
            numeroC = double.Parse(Console.ReadLine());

            delta = (numeroB * numeroB) - (4 * numeroA * numeroC);

            if(delta < 0)
            {
                Console.WriteLine("Não é possível determinar as raizes para Delta negativo!");
            }
            else
            {
                raiz1 = ((-numeroB) + (Math.Sqrt(delta))) / 2;
                raiz2 = ((-numeroB) - (Math.Sqrt(delta))) / 2;

                Console.WriteLine("A primeira raiz é: " + raiz1);
                Console.WriteLine("A segunda raiz é: " + raiz2);
            }          
        }
    }
}
