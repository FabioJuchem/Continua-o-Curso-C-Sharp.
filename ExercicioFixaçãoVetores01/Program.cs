using System;
using System.Globalization;

namespace ExercicioFixaçãoVetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vet = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for ( int  i = 1;i <= n; i ++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel # " + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);


            }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if ( vet[i] != null)
                {
                    Console.WriteLine(i + ", "+  vet[i]);
                }
            }




        }
    }
}
