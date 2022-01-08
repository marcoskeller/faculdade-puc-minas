using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class  Exercicio_05_IndiceMassaCorporal
    {
        /*
         * 5) Faça um algoritmo em C# para calcular o IMC (Índice de Massa Corporal) de um indivíduo, 
              que é a relação entre o seu peso e o quadrado da sua altura, ou seja:

                

                O algoritmo deve solicitar ao usuário os valores do peso e da altura e escrever o resultado do valor do IMC. 
                Em seguida, deve determinar e escrever qual é a situação, conforme a escala abaixo:

                a) abaixo de 20: abaixo do peso;
                b) de 20 (inclusive) a 25: peso normal;
                c) de 25 (inclusive) a 30: sobrepeso;
                d) de 30 (inclusive) a 40: obesidade;
                e igual ou superior a 40: obesidade mórbida.
         */

        public static void IndiceMassaCorporal()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Indice de Massa Corporal<-------------------");
            double altura, peso, resultado;
         

            
            Console.Write("\n\nDigite a sua altura em (m): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o seu peso em Kg: ");
            peso = double.Parse(Console.ReadLine());

            resultado = (peso / (altura * altura));

            if(resultado < 20)
            {
                Console.WriteLine("\n\nResultado");
                Console.WriteLine("\nIMC = " + resultado + "\nAbaixo do Peso");
            }
            else if (resultado >= 20 && resultado < 25)
            {
                Console.WriteLine("\n\nResultado");
                Console.WriteLine("\nIMC = " + resultado + "\nPeso Normal");
            }
            else if (resultado >= 25 && resultado < 30)
            {
                Console.WriteLine("\n\nResultado");
                Console.WriteLine("\nIMC = " + resultado + "\nSobrepeso");
            }
            else if (resultado >= 30 && resultado < 40)
            {
                Console.WriteLine("\n\nResultado");
                Console.WriteLine("\nIMC = " + resultado + "\nObesidade");
            }
            else
            {
                Console.WriteLine("\n\nResultado");
                Console.WriteLine("\nIMC = " + resultado + "\nObesidade Mórbida");
            }

        }
    }
}
