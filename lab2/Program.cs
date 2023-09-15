using System.Diagnostics.Metrics;
using System.IO;
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

class Address {
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

}

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUah(double val, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return val * usdRate;
            case "eur":
                return val * eurRate;
            case "pln":
                return val * plnRate;
            default:
                Console.WriteLine("Помилка, перевірте коректність введених даних");
                return 0.0;
        }
    }
    public double ConvertFromUah(double val, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return val / usdRate;
            case "eur":
                return val / eurRate;
            case "pln":
                return val / plnRate;
            default:
                Console.WriteLine("Помилка, перевірте коректність введених даних");
                return 0.0;
        }
    }
}

class Employee
{
    private string name;
    private string surname;

    public Employee(string firstName, string lastName) {
        name = firstName;
        surname = lastName;
    }

    public void SalaryCalculator(string position, double expirience) {
        double salary = 0;

        switch (position.ToLower()) {
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

    class Program
{
    static void Main()
    {
        Address myAddress = new Address
        {
            Index = "123",
            Country = "Україна",
            City = "Київ",
            Street = "Романа шухевича",
            House = "13",
            Apartment = "32"
        };

        Console.WriteLine("Індекс: " + myAddress.Index);
        Console.WriteLine("Країна: " + myAddress.Country);
        Console.WriteLine("Місто: " + myAddress.City);
        Console.WriteLine("Вулиця: " + myAddress.Street);
        Console.WriteLine("Будинок: " + myAddress.House);
        Console.WriteLine("Квартира: " + myAddress.Apartment);


        // Конвертація валют
        Converter converter = new Converter(36.93, 39.42, 8.48);


        User user = new User("karex", "Vadym", "Ternavsky", 18);

        user.DisplayUserInfo();

        Console.ReadLine();
    }
}