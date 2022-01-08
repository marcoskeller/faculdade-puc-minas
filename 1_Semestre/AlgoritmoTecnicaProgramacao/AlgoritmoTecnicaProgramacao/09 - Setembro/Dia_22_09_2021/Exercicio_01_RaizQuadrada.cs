using System;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class Exercicio_01_RaizQuadrada
    {
        /*
         * 1) Faça um algoritmo em C# que leia um número e imprima a raiz quadrada do número caso ele seja positivo ou igual a zero 
              e o quadrado do número caso ele seja negativo.
              Considere que a linguagem C# tem a função Math.Sqrt(x) para cálculo da raiz quadrada de x e Math.Pow(x, y) para cálculo da potência xy.
         */

        public static void RaizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Raiz Quadrada<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            double numeroInformado, raizQuadrada;


            Console.Write("\n\nDigite o número que deseja saber a raiz quadrada: ");
            numeroInformado = double.Parse(Console.ReadLine());

            if(numeroInformado >= 0)
            {
                raizQuadrada = Math.Sqrt(numeroInformado);
                Console.Write("\n\nA raiz quadrada do número "+ numeroInformado + " é: " + raizQuadrada);
            }
            else
            {
                raizQuadrada = numeroInformado * numeroInformado;
                Console.Write("\n\nO quadrado do número " + numeroInformado + " é: " + raizQuadrada);
            }
        }
    }
}
