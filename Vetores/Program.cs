using System;
using System.Globalization;

namespace Exemplo_Vetores_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for ( int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }

            double avg = soma / n;
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
