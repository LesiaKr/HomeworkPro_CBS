/*Завдання 4 
Створіть колекцію, в яку можна записувати два значення одного слова, на кшталт українсько-англо-німецького словника. І в ній можна для українського слова знайти або лише німецьке значення, або лише англійське та вивести його на екран. */

using System.Text;

namespace EngGerDictionary
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            CustomDictionary dictionary = new CustomDictionary();
            dictionary.Add("кіт", "cat", "Katze");
            dictionary.Add("собака", "dog", "Hund");

            Console.WriteLine("Англійське значення для 'кіт': " + dictionary.GetEnglish("кіт"));
            Console.WriteLine("Німецьке значення для 'собака': " + dictionary.GetGerman("собака"));
        }
    }
}