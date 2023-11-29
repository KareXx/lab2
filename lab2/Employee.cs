using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Employee
    {
        private string name;
        private string surname;

        public Employee(string firstName, string lastName)
        {
            name = firstName;
            surname = lastName;
        }

        public void SalaryCalculator(string position, double expirience)
        {
            double salary = 0;

            switch (position.ToLower())
            {
                case "розробник":
                    salary = 1000;
                    break;
                case "начальник розробника":
                    salary = 2000;
                    break;
                case "начальник начальника розробника":
                    salary = 5000;
                    break;
                case "прибиральник":
                    salary = 500;
                    break;
                default:
                    Console.WriteLine("Посади не було знайдено");
                    break;
            }

            double fullSalary = salary + (expirience * 200);

            double tax = fullSalary * 0.15;

            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine("Ім'я: " + name);
            Console.WriteLine("Прізвище: " + surname);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + fullSalary);
            Console.WriteLine("Податковий збір: " + tax);
        }
    }
}
