using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixaçãoListas01
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }

        public void IncreaseSalary(double Percent)
        {
            Salary += Salary * Percent / 100.00;
        }

        public override string ToString()
        {
            return Name + ", " + Salary;
        }
    }
}
