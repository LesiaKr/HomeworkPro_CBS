/*Завдання 4 
Створіть колекцію типу OrderedDictionary та реалізуйте у ній можливість порівняння значень.*/

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;

public class ValueComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var order = new OrderedDictionary
        {
            {"Олег Іванів", "Дрібна побутова техніка"},
            {"Назар Петрів", "Мобільні телефони"},
            {"Тарас Дутка", "Техніка для кухні"},
            {"Ольга Дубок", "Ноутбуки"},
            {"Наталя Тарасів", "Ноутбуки"},
            {"Таня Петрів", "Мобільні телефони"}
        };

        CheckForDuplicateValues(order);
    }

    static void CheckForDuplicateValues(OrderedDictionary dictionary)
    {
        ValueComparer comparer = new ValueComparer();
        var duplicateValues = new HashSet<string>();

        foreach (DictionaryEntry entry1 in dictionary)
        {
            foreach (DictionaryEntry entry2 in dictionary)
            {
                if (!entry1.Key.Equals(entry2.Key) && comparer.Compare(entry1.Value, entry2.Value) == 0)
                {
                    duplicateValues.Add(entry1.Value.ToString());
                }
            }
        }

        if (duplicateValues.Count > 0)
        {
            Console.WriteLine("Колекція має однакові значення:");
            foreach (var value in duplicateValues)
            {
                Console.WriteLine(value);
            }
        }
        else
        {
            Console.WriteLine("Колекція не має однакових значень.");
        }
    }
}
