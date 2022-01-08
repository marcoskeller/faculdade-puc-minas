using System;


namespace AlgoritmoTecnicaProgramacao.Dia_06_10_2021
{
    public class MediaNumeroDesejado
    {
        public static void MediaAvancada()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Programa Calculo de Médias Ate Um Valor Desejado<-------------------");
            double x, y, z, media = 1;


            while (media <= 30)
            {
                Console.Write("\n\nDigite o valor de x: ");
                x = double.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o valor de y: ");
                y = double.Parse(Console.ReadLine());

                Console.Write("\n\nDigite o valor de z: ");
                z = double.Parse(Console.ReadLine());

                media = (x + y + z) / 3;
                Console.WriteLine("\n\n A média dos números (" + x + "),(" + y + "),(" + z + ") é: " + media + "\n\n");
            }
        }
    }
}
