using System;

namespace AlgoritmoTecnicaProgramacao.Dia_25_08_2021
{
    public class  Exercicio_05_CaixaDAguaCilindrica
    {
        /*
         * 5) Faça um algoritmo em Portugol para:
                a) ler o raio da base e a altura de uma caixa d'água cilíndrica;
                b) calcular a área da base e o volume da caixa;
                c) exibir suas medidas e o resultado do volume.
                Considere que o Portugol tem a constante "pi", utilizada na Matemática.
         */
        public static void CaixaDAguaCilindrica()
        {
            double comprimentoRaioCaixaDAgua = 0, alturaCaixaDAguaCilindrica = 0, larguraCaixaDAgua = 0, areaCaixaDAguaCilindrica = 0;

            Console.Write("\n\nDigite o comprimento do Raio da Caixa D'Agua Cilíndrica: ");
            comprimentoRaioCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a altura da Caixa D'Agua Cilíndrica: ");
            alturaCaixaDAguaCilindrica = double.Parse(Console.ReadLine());

            areaCaixaDAguaCilindrica = (Math.PI * (comprimentoRaioCaixaDAgua * comprimentoRaioCaixaDAgua)) * alturaCaixaDAguaCilindrica;

            Console.WriteLine("\n\nRelatório Final");
            Console.WriteLine("\nValor do Comprimento do Raio da Caixa D'Agua Cilíndrica é: " + comprimentoRaioCaixaDAgua);
            Console.WriteLine("\nValor da Altura da Caixa D'Agua Cilíndrica é:" + alturaCaixaDAguaCilindrica);
            Console.WriteLine("\nÁrea Total da Caixa D'Agua é: " + areaCaixaDAguaCilindrica);
        }
    }
}
