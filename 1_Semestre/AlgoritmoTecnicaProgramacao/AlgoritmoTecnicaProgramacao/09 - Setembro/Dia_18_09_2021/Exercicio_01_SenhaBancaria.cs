using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class  Exercicio_01_SenhaBancaria
    {
        /*
         * 1) Faça um algoritmo em C# que:
                a) leia um número inteiro x correspondente a uma senha bancária;
                b) leia um número inteiro y correspondente à senha que o cliente 
                do banco está informando. Caso o valor lido não corresponda à senha correta, 
                deve-se exibir a mensagem "Acesso negado". Caso o valor lido corresponda à senha correta, 
                deve-se exibir a mensagem "Acesso permitido".
         */

        public static void SenhaBancaria()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Senha Bancária<-------------------");
            int  senhaPessoalConta, senhaCliente;

            
            Console.Write("\n\nCadastre sua senha bancária: ");
            senhaPessoalConta = int.Parse(Console.ReadLine());

            Console.Write("Digite a senha da sua conta Bancária: ");
            senhaCliente = int.Parse(Console.ReadLine());

            if(senhaPessoalConta == senhaCliente)
            {
                Console.WriteLine("\n\nAcesso permitido");
            }
            else
            {
                Console.WriteLine("\n\nAcesso negado");
            }
        }
    }
}
