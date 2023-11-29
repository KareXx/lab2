using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime DateOfСompletion { get; }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            DateOfСompletion = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("Інформація про користувача:");
            Console.WriteLine("Логін: " + Login);
            Console.WriteLine("Ім'я: " + Name);
            Console.WriteLine("Прізвище: " + Surname);
            Console.WriteLine("Вік: " + Age);
            Console.WriteLine("Дата реєстрації: " + DateOfСompletion);
        }

    }
}
