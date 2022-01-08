using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{
    public class Exercicio_03_CaixaDAguaQuadrangular
    {
        /*
         * 3) Faça um algoritmo em Portugol para:
                a) ler as medidas de uma caixa d'água quadrangular;
                b) calcular o volume da caixa;
                c) exibir suas medidas e o resultado do volume.
         */

        public static void CaixaDAguaQuadrada()
        {
            double comprimentoCaixaDAgua = 0, alturaCaixaDAgua = 0, larguraCaixaDAgua = 0, areaCaixaDAgua = 0;

            Console.Write("\n\nDigite o comprimento da Caixa D'Agua: ");
            comprimentoCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a largura da Caixa D'Agua: ");
            larguraCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a altura da Caixa D'Agua: ");
            alturaCaixaDAgua = double.Parse(Console.ReadLine());

            areaCaixaDAgua = comprimentoCaixaDAgua * larguraCaixaDAgua * alturaCaixaDAgua;

            Console.WriteLine("\n\nRelatório Final");
            Console.WriteLine("\nValor do Comprimento da Caixa D'Agura é: " + comprimentoCaixaDAgua);
            Console.WriteLine("\nValor da Lagura da Caixa D'Agura é: " + larguraCaixaDAgua);
            Console.WriteLine("\nValor da Altura da Caixa D'Agua é:" + alturaCaixaDAgua);
            Console.WriteLine("\nÁrea Total da Caixa D'Agua é: " +  areaCaixaDAgua);

        }
    }
}