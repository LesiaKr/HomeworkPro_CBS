/*Завдання 6
Напишіть консольну програму, яка дозволяє користувачеві зареєструватися під «Логіном», що складається тільки з символів 
латинського алфавіту, і пароля, що складається з цифр і символів.*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Реєстрація користувача");

        string login = GetValidLogin();
        string password = GetValidPassword();

        Console.WriteLine("Реєстрація успішна!");
        Console.WriteLine($"Ваш логін: {login}");
        Console.WriteLine($"Ваш пароль: {password}");
    }

    static string GetValidLogin()
    {
        string loginPattern = @"^[a-zA-Z]+$";
        while (true)
        {
            Console.Write("Введіть логін (тільки символи латинського алфавіту): ");
            string login = Console.ReadLine();
            if (Regex.IsMatch(login, loginPattern))
            {
                return login;
            }
            else
            {
                Console.WriteLine("Невірний логін. Спробуйте ще раз.");
            }
        }
    }

    static string GetValidPassword()
    {
        string passwordPattern = @"^[a-zA-Z0-9]+$";
        while (true)
        {
            Console.Write("Введіть пароль (тільки цифри і символи): ");
            string password = Console.ReadLine();
            if (Regex.IsMatch(password, passwordPattern))
            {
                return password;
            }
            else
            {
                Console.WriteLine("Невірний пароль. Спробуйте ще раз.");
            }
        }
    }
}
