using System;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class  Exercicio_04_PostoDeCombustivel
    {
        /*
         * 4) Um posto de combustíveis dá descontos aos seus clientes de acordo com a quantidade de litros de combustível abastecidos:
                a) de 10 a 30 litros: 1%;
                b) mais de 30 e menos de 40 litros: 2%
                c) 40 litros ou mais: 2.5%
                Faça um algoritmo em C# que:
                a) leia a quantidade de litros abastecidos e o preço de um litro de combustível;
                b) calcule o valor total do combustível, o valor do desconto e o valor a pagar;
                c) escreva os valores lidos e os calculados.
         */

        public static void PostoCombustivel()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Posto Combustível<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            double quantidadeAbastecidaCombustivel, precoLitroCombustivel, valorTotalCombustivelSemDesconto, valorDesconto, ValorTotalPagarComDesconto;
            

            Console.Write("\n\nDigite a quantidade abastecida de combustível: ");
            quantidadeAbastecidaCombustivel = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o preco do litro de combustível: ");
            precoLitroCombustivel = double.Parse(Console.ReadLine());

            valorTotalCombustivelSemDesconto = precoLitroCombustivel * quantidadeAbastecidaCombustivel;
            
            if(quantidadeAbastecidaCombustivel < 10)
            {
                Console.WriteLine("\n\nQuantidade abastecida não contempla a promoção!!!");
                Console.WriteLine("\n\nRelatório Atualizado!!!");
                Console.WriteLine("\nValor Preço do Litro de Combustível: R$" + precoLitroCombustivel);
                Console.WriteLine("\nQuantidade Abastecida de Combustível: " + quantidadeAbastecidaCombustivel + "Litros");
                Console.WriteLine("\nValor do Desconto Ganho: R$" + 0.00);
                Console.WriteLine("\nValor Total a Pagar Sem Descontro: R$" + valorTotalCombustivelSemDesconto);
            }
            else if(quantidadeAbastecidaCombustivel >= 10  && quantidadeAbastecidaCombustivel <= 30)
            {
                valorDesconto = valorTotalCombustivelSemDesconto * 0.01;
                ValorTotalPagarComDesconto = valorTotalCombustivelSemDesconto - valorDesconto;

                Console.WriteLine("\n\nRelatório Atualizado!!!");
                Console.WriteLine("\nValor Preço do Litro de Combustível: R$" + precoLitroCombustivel);
                Console.WriteLine("\nQuantidade Abastecida de Combustível: " + quantidadeAbastecidaCombustivel + "Litros");
                Console.WriteLine("\nValor do Desconto Ganho: R$" + valorDesconto);
                Console.WriteLine("\nValor Total a Pagar com Descontro: R$" + ValorTotalPagarComDesconto);
            }
            else if (quantidadeAbastecidaCombustivel > 30 && quantidadeAbastecidaCombustivel < 40)
            {
                valorDesconto = valorTotalCombustivelSemDesconto * 0.02;
                ValorTotalPagarComDesconto = valorTotalCombustivelSemDesconto - valorDesconto;

                Console.WriteLine("\n\nRelatório Atualizado!!!");
                Console.WriteLine("\nValor Preço do Litro de Combustível: R$" + precoLitroCombustivel);
                Console.WriteLine("\nQuantidade Abastecida de Combustível: " + quantidadeAbastecidaCombustivel + "Litros");
                Console.WriteLine("\nValor do Desconto Ganho: R$" + valorDesconto);
                Console.WriteLine("\nValor Total a Pagar com Descontro: R$" + ValorTotalPagarComDesconto);
            }
            else
            {
                valorDesconto = valorTotalCombustivelSemDesconto * 0.025;
                ValorTotalPagarComDesconto = valorTotalCombustivelSemDesconto - valorDesconto;

                Console.WriteLine("\n\nRelatório Atualizado!!!");
                Console.WriteLine("\nValor Preço do Litro de Combustível: R$" + precoLitroCombustivel);
                Console.WriteLine("\nQuantidade Abastecida de Combustível: " + quantidadeAbastecidaCombustivel + "Litros");
                Console.WriteLine("\nValor do Desconto Ganho: R$" + valorDesconto);
                Console.WriteLine("\nValor Total a Pagar com Descontro: R$" + ValorTotalPagarComDesconto);
            }
        }
    }
}
