using System;

namespace Exemplo_Vetores_03
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i <vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("--------------------------");

            foreach (string obj in vet)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
