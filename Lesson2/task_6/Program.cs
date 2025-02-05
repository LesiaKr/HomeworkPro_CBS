/*Завдання 6 
Використовуючи клас SortedList, створіть невелику колекцію та виведіть на екран значення пар «ключ-значення» спочатку 
в алфавітному порядку, а потім у зворотному.*/

using System;
using System.Collections;
using System.Text;

namespace MySortedList
{
    class Programa
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var sort = new SortedList(new DescendingComparer());

            sort["Андрій"] = "Коваль";
            sort["Яків"] = "Петрів";
            sort["Олександр"] = "Іванів";
            sort["Тетяна"] = "Малик";
            sort["Христина"] = "Яців";
            sort["Вікторія"] = "Петрів";

            var keys = new ArrayList(sort.Keys);
            keys.Reverse();

            Console.WriteLine("Сортування в алфавітному порядку: ");
            foreach (var key in keys)
            {
                Console.WriteLine("{0} = {1}", key, sort[key]);
            }
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Сортування в зворотному порядку: ");
            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }
            Console.ReadKey();
        }
    }

    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = comparer.Compare(y, x);
            return result;
        }
    }
}
