using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class Exercicio_03_TipoEleitor
    {
        /*
         * 3) Escreva um algoritmo em C# que
                a) leia a idade de uma pessoa;
                b) determine e escreva o tipo de eleitor segundo os critérios abaixo:
                   i) menor de 16 anos: não eleitor;
                   ii) de 16 a 17 anos, ou mais de 69 anos: eleitor facultativo;
                   iii) de 18 a 69 anos: eleitor obrigatório.
         */

        public static void TipoEleitor()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Tipo de Eleitor<-------------------");
            int idadeEleitor = 0;
            string nomeEleitor;

            Console.Write("\n\nDigite o nome de quem deseja se cadastrar: ");
            nomeEleitor = Console.ReadLine();

            Console.Write("\n\nDigite a idade da pessoa que deseja se cadastrar: ");
            idadeEleitor = int.Parse(Console.ReadLine());

            if(idadeEleitor < 16)
            {
                Console.Write("\n\nPara "+ nomeEleitor + " não pode votar porque tem menos de 16 anos de idade!");
            }
            else if(idadeEleitor >= 16 && idadeEleitor <= 17 || idadeEleitor >= 69)
            {
                Console.Write("\n\nPara " + nomeEleitor + " pode votar mas não é obrigatório!");
            }
            else
            {
                Console.Write("\n\nPara " + nomeEleitor + " votar é obrigatório!");
            }
        }
    }
}
