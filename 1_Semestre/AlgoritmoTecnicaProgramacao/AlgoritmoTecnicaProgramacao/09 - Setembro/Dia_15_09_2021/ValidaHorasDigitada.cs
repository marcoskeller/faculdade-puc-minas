using System;

namespace AlgoritmoTecnicaProgramacao.Dia_15_09_2021
{
    public class ValidaHorasDigitada
    {
        public static void ValidaHoras()
        {
            //1) Faça um algoritmo em C# que leia dois números inteiros que correspondam a valores de horas e minutos. Em seguida, deve determinar se é um horário válido.

            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Validar Horas Digitadas<-------------------");
            int hora, minutos, segundos;

            Console.Write("\n\nDigite o valor para a hora: ");
            hora = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para os minutos: ");
            minutos = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor para os segundos: ");
            segundos = int.Parse(Console.ReadLine());

            if(hora >=0 && hora <= 23 && minutos >= 0 && minutos < 60 && segundos >= 0 && segundos < 59)
            {
                Console.WriteLine("São exatamento: "+ hora + ":" + minutos + ":" + segundos);
            }
            else
            {
                Console.WriteLine("Hora informada é inválida!");
            }
        }      
    }
}
