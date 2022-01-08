using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class  Exercicio_04_MensalidadeClube
    {
        /*
         * 4) Em um clube há dois tipos de sócios: proprietário e usuário. Haverá um reajuste nas mensalidades de 15% 
              para o sócio proprietário e 12% para o sócio usuário. Faça um algoritmo em C# que:

                a) leia o código do tipo de sócio (1 - proprietário e 2 - usuário) e o valor da mensalidade;
                b) calcule o valor do aumento e da nova mensalidade;
                c) escreva o código do usuário, o valor atual da mensalidade, o valor do reajuste e o valor da nova mensalidade.
         */

        public static void MensalidadeClube()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Mensalidade do Clube<-------------------");
            double reajusteMensalidadeSocio = 0, mensalidade = 0, reajusteMensalidade;
            int codigoSocio;

            Console.WriteLine("\n\n1 - Proprietário\n2 - Usuário");
            Console.Write("\n\nDigite o código do sócio:");
            codigoSocio = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor da Mensalidade: ");
            mensalidade = double.Parse(Console.ReadLine());
            
            if(codigoSocio == 1)
            {
                reajusteMensalidadeSocio = mensalidade * 0.15;
                reajusteMensalidade = mensalidade + (mensalidade * 0.15);
            }
            else
            {
                reajusteMensalidadeSocio = mensalidade * 0.12;
                reajusteMensalidade = mensalidade + (mensalidade * 0.12);
            }

            Console.Write("\n\n\nRelatório Final");
            Console.Write("\nCódigo do Sócio: " + codigoSocio); 
            Console.Write("\nValor Atual da Mensalidade: R$" + mensalidade );
            Console.Write("\nValor do Reajuste que será aplicado: R$" + reajusteMensalidadeSocio); 
            Console.Write("\nValor da Nova Mensalidade: R$" + reajusteMensalidade);

        }
    }
}
