using System;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class  Exercicio_02_CaixaDAgua
    {
        /*
         * 2) Faça um algoritmo em C# para:
                a) ler o tipo de uma caixa d'água (1 para quadrangular e 2 para cilíndrica - qualquer outro valor é inválido);
                b) ler as dimensões da caixa d'água (em metros) e calcular seu volume;
                c) exibir as dimensões e o volume da caixa.
                Considere que a linguagem C# tem a constante Math.Pi.
         */
        
        public static void CaixaDAgua()
        {

            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Caixa D'Agua<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            double comprimentoCaixaDAgua, larguraCaixaDAgua, alturaCaixaDAgua, comprimentoRaioCaixaDAgua, areaCaixaDAgua, volumeCaixaDAgua;
            int tipoCaixaDAgua;

            Console.WriteLine("\n\n1 - Caixa D'Agua Quadrangular\n2 - Caixa D'Agua Cilíndrica");
            Console.Write("\n\nDigite o Tipo de Caixa D'Agua que será calculado: ");
            
            tipoCaixaDAgua = int.Parse(Console.ReadLine());
           
            switch (tipoCaixaDAgua)
            {
                case 1:
                    CaixaDAguaQuadrangular();
                    break;
                case 2:
                    CaixaDAguaCilindrica();
                    break;
                default:
                    Console.WriteLine("Opção digitada é inválida!");
                    break;
            }         
        }

        public static void CaixaDAguaQuadrangular()
        {
            double comprimentoCaixaDAgua, larguraCaixaDAgua, alturaCaixaDAgua, volumeCaixaDAgua;

            Console.Write("\n\nDigite o comprimento em (m) da Caixa D'Agua: ");
            comprimentoCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a largura em (m) da Caixa D'Agua: ");
            larguraCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a altura em (m) da Caixa D'Agua: ");
            alturaCaixaDAgua = double.Parse(Console.ReadLine());

            volumeCaixaDAgua = comprimentoCaixaDAgua * larguraCaixaDAgua * alturaCaixaDAgua;

            Console.WriteLine("\n\nRelatório Final");
            Console.WriteLine("\nComprimento da Caixa D'Agura é: " + comprimentoCaixaDAgua + "m");
            Console.WriteLine("\nLagura da Caixa D'Agura é: " + larguraCaixaDAgua + "m");
            Console.WriteLine("\nAltura da Caixa D'Agua é:" + alturaCaixaDAgua + "m");
            Console.WriteLine("\nVolume Total da Caixa D'Agua é: " + volumeCaixaDAgua + "m³");
        }

        public static void CaixaDAguaCilindrica()
        {
            double comprimentoRaioCaixaDAgua, alturaCaixaDAgua, volumeCaixaDAgua;

            Console.Write("\n\nDigite o comprimento do Raio da Base em (m) da Caixa D'Agua: ");
            comprimentoRaioCaixaDAgua = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a altura em (m) da Caixa D'Agua: ");
            alturaCaixaDAgua = double.Parse(Console.ReadLine());

            volumeCaixaDAgua = (Math.PI * (Math.Pow(comprimentoRaioCaixaDAgua, comprimentoRaioCaixaDAgua))) * alturaCaixaDAgua;
           
            Console.WriteLine("\n\nRelatório Final");
            Console.WriteLine("\nComprimento do Raio da Base da Caixa D'Agura é: " + comprimentoRaioCaixaDAgua + "m");
            Console.WriteLine("\nAltura da Caixa D'Agua é:" + alturaCaixaDAgua + "m");
            Console.WriteLine("\nVolume Total da Caixa D'Agua é: " + volumeCaixaDAgua + "m³");
        }
    }
}
