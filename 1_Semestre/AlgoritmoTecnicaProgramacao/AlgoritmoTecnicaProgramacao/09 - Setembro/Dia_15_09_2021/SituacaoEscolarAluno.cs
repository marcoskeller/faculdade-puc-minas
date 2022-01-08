using System;

namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class SituacaoEscolarAluno
    {
        public static void SituacaoAluno()
        {
            /*
            4) Escreva um algoritmo em C# para ler as notas das quatro avaliações de um aluno no semestre, calcular e escrever a média semestral e a seguinte mensagem:
            a) “PARABÉNS! Você foi aprovado”: somente se o aluno obteve média com valor igual ou superior a 60 pontos;
            b) “Você foi REPROVADO! Estude mais”: somente se o aluno obteve média com valor inferior a 60 pontos.
            */

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calcuar a Equação de Segundo Grau<-------------------");

            double avaliacao1, avaliacao2, avaliacao3, avaliacao4, mediaSemestral;

            Console.Write("\n\nDigite o valor da Primeira Avaliação: ");
            avaliacao1 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor da Segunda Avaliação: ");
            avaliacao2 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor da Terceira Avaliação: ");
            avaliacao3 = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor da Quarta Avaliação: ");
            avaliacao4 = double.Parse(Console.ReadLine());

            mediaSemestral = (avaliacao1 + avaliacao2 + avaliacao3 + avaliacao4) / 4;

            if(mediaSemestral >= 60)
            {
                Console.WriteLine("PARABÉNS! Você foi aprovado!");
            }
            else
            {
                Console.WriteLine("Você foi REPROVADO! Estude mais");
            }
        }
    }
}
