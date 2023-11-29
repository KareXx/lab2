using System.Diagnostics.Metrics;
using System.IO;
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace lab2
{
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
            converter.ConvertFromUah(10, "sd");

            User user = new User("karex", "Vadym", "Ternavsky", 18);

            user.DisplayUserInfo();

            Console.ReadLine();
        }
    }
}
    