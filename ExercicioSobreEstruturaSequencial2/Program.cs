using System;
using System.Globalization;

namespace ExercicioSobreEstruturaSequencial2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.*/

            double pi = 3.14159;

            Console.WriteLine("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * raio * raio;

            Console.WriteLine($"O valor total da área do círculo é " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
