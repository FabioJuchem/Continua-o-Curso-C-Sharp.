using System;
using System.Collections.Generic;
namespace ExemploListas01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("list count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2) ;

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position: " + pos1);

            Console.WriteLine("-----------------------------");
            List<string> list2 = lista.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");
            lista.Remove("Alex");
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");
            lista.RemoveAll(x => x[0] == 'M');
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");









        }
             
    }
}
