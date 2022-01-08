using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{
    public class  Exercicio_04_DinherioNoCofre
    {
        /*
         * 4) Um cofrinho, contendo moedas de R$ 1,00, R$ 0,50, R$ 0,25 e R$ 0,10 foi aberto. Escreva um algoritmo em Portugol que:
                a) leia a quantidade de moedas de cada valor;
                b) calcule o valor apurado, em reais, de cada tipo de moeda;
                c) calcule o valor total apurado, em reais;
                d) escreva:
                i) a quantidade de cada moeda;
                ii) o total de cada moeda;
                iii) o valor total apurado.
         */

        public static void DinheiroNoCofre()
        {
            double totalMoedaUmReal, totalMoedaCinquentaCentavos, totalMoedaVinteCincoCentavos, totalMoedaDezCentavos, totalFinal;
            int quantidadeMoedasUmReal = 0, quantidadeMoedasCinquentaCentavos = 0, quantidadeMoedaVinteCincoCentavos = 0, quantidadeMoedaDezCentavos = 0;

            Console.Write("\n\nDigite a quantidade de moeda de R$1,00 Real: ");
            quantidadeMoedasUmReal = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade de moeda de R$0,50 Centavos: ");
            quantidadeMoedasCinquentaCentavos = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade de moeda de R$0,25 Centavos: ");
            quantidadeMoedaVinteCincoCentavos = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade de moeda de R$0,10 Centavos: ");
            quantidadeMoedaDezCentavos = int.Parse(Console.ReadLine());

            totalMoedaUmReal = quantidadeMoedasUmReal * 1.00;
            totalMoedaCinquentaCentavos = quantidadeMoedasCinquentaCentavos * 0.50;
            totalMoedaVinteCincoCentavos = quantidadeMoedaVinteCincoCentavos * 0.25;
            totalMoedaDezCentavos = quantidadeMoedaDezCentavos * 0.10;
            totalFinal = totalMoedaUmReal + totalMoedaCinquentaCentavos + totalMoedaVinteCincoCentavos + totalMoedaDezCentavos;

            Console.WriteLine("Relatório Final");
            Console.Write("\n\nQuantidade de Moeda de R$1.00 Real é: "+ quantidadeMoedasUmReal);
            Console.Write("\nQuantidade de Moeda de R$0.50 Centavos é: " + quantidadeMoedasCinquentaCentavos);
            Console.Write("\nQuantidade de Moeda de R$0.25 Centavos é: " + quantidadeMoedaVinteCincoCentavos);
            Console.Write("\nQuantidade de Moeda de R$0.10 Centavos é: " + quantidadeMoedaDezCentavos);

            Console.Write("\n\nQuantidade Total que havia no Cofre é de R$ " + totalFinal + " Reais");

        }
    }
}