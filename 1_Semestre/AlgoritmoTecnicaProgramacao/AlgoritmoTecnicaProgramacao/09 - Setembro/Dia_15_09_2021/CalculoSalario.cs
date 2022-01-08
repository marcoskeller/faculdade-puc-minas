using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class CalculoSalario
    {
        public static void SalarioTotal()
        {
            /*
            2) Construa um algoritmo em C# que leia os valores do salário base e da quantidade de horas extras mensais de um empregado. Em seguida, o algoritmo deve calcular e mostrar o rendimento mensal total do empregado seguindo a seguinte tabela:
            a) de 1 a 10 horas extras: o valor de cada hora extra é de 1 % do salário base
            b) de 11 a 20 horas extras: o valor de cada hora extra é de 2 % do salário base
            c) acima de 20 horas extras: o valor de cada hora extra é de 3 % do salário base.
            */

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calculo Salario Base<-------------------");
            double salarioBase, quantidadeHorasExtras, salarioTotal = 0;

            Console.Write("\n\nDigite o valor do salario base do Empregado: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a quantidade de horas extras realizadas pelo Empregado: ");
            quantidadeHorasExtras = double.Parse(Console.ReadLine());

            if(quantidadeHorasExtras < 1)
            {
                Console.WriteLine("\n\nEmpregado não atigiu o mínimo de horas extras para receber a bonificação salarial!");
            }
            else if(quantidadeHorasExtras >=1 && quantidadeHorasExtras <= 10)
            {
                salarioTotal = salarioBase + (salarioBase * 0.01);
            }
            else if(quantidadeHorasExtras > 10 && quantidadeHorasExtras <= 20)
            {
                salarioTotal = salarioBase + (salarioBase * 0.02);
            }
            else
            {
                salarioTotal = salarioBase + (salarioBase * 0.03);
            }

            Console.WriteLine("\n\nO salario final do Empregado é: R$" + salarioTotal);
        }
    }
}

