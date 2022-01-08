using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{
    public class  Exercicio_02_TrabalhoComArame
    {
        /*
            2) Faça um algoritmo em Portugol para:
                a) ler o comprimento de um pedaço de arame;
                b) calcular o lado do quadrado que se pode construir com esse arame;
                c) calcular a área desse quadrado;
                d) escrever o comprimento do arame, o lado e a área do quadrado. 
         */

        public static void TrabalhoComArame()
        {
            double tamanhoPedacoArame, areaQuadradoArame, tamanhoLadoQuadrado = 0;

            Console.Write("\n\nDigite o tamanho do pedaço de Arame Disponível: ");
            tamanhoPedacoArame = double.Parse(Console.ReadLine());

            tamanhoLadoQuadrado = tamanhoPedacoArame / 4;
            areaQuadradoArame = tamanhoLadoQuadrado * tamanhoLadoQuadrado;

            Console.WriteLine("\n\nTamanho do Arame Fornecido: " + tamanhoPedacoArame);
            Console.WriteLine("\nTamanho Máximo do Lado do Quadrado: " + tamanhoLadoQuadrado);
            Console.WriteLine("\nÁrea do Quadro é : " + areaQuadradoArame);


        }
    }
}
