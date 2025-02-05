/*Завдання 2
Напишіть програму, яка дозволила б за вказаною адресою web-сторінки вибирати всі посилання на інші сторінки,
номери телефонів, поштові адреси та зберігала отриманий результат у файл.*/

using System.Text;
using System.Text.RegularExpressions;

namespace SearchWebInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string input = "";
            input += "<a href='http://cbsystematics.com'>Home-page</a>";
            input += "<a href='http://google.com'>Search</a>";
            input += "<a href=\"tel:+380988099714\"> <span>098 809 97 14</span> </a>";
            input += "<a href=\"tel:+380995170461\"> <span>099 517 04 61</span> </a>";
            input += "<a href=\"mailto:edu@cbsystematics.com\">edu@cbsystematics.com</a>";

            var linkRegex = new Regex(@"href='(?<link>http[s]?://[^']+)'>(?<text>[^<]+)</a>");
            var phoneRegex = new Regex(@"href=""tel:(?<phone>[^""]+)"">");
            var emailRegex = new Regex(@"href=""mailto:(?<email>[^""]+)"">(?<emailText>[^<]+)</a>");

            Console.WriteLine("Посилання:");
            foreach (Match m in linkRegex.Matches(input))
            {
                Console.WriteLine($"Link: {m.Groups["link"].Value}, Text: {m.Groups["text"].Value}");
            }

            Console.WriteLine("\nНомера телефонів:");
            foreach (Match m in phoneRegex.Matches(input))
            {
                Console.WriteLine($"Phone: {m.Groups["phone"].Value}");
            }

            Console.WriteLine("\nEmail адреси:");
            foreach (Match m in emailRegex.Matches(input))
            {
                Console.WriteLine($"Email: {m.Groups["email"].Value}, Text: {m.Groups["emailText"].Value}");
            }
        }
    }
}