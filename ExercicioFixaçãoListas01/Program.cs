using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixaçãoListas01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Digite quantos funcionarios seram cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado# "+ i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add( new Employee(id, name, salary)); 
            }

            Console.WriteLine("Digite o ID do empregado que tera salario aumentado: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null)
            {
                Console.WriteLine("Digite a porcentagem de aumento");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("Codigo invalido");
            }

            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
