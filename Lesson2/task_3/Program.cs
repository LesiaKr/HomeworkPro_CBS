/*Завдання 3
Декількома способами створіть колекцію, в якій можна зберігати 
тільки цілі та речові значення, на кшталт «рахунок підприємства – доступна сума» відповідно.*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        // 1-ий варіант
        Dictionary<int, decimal> accountBalances1 = new Dictionary<int, decimal>();
        accountBalances1.Add(1, 1000.50m);
        accountBalances1.Add(2, 2500.75m);
        Console.WriteLine("Dictionary<int, decimal>");
        foreach (var account in accountBalances1)
        {
            Console.WriteLine($"Рахунок {account.Key} - Доступна сума: {account.Value}");
        }
        Console.WriteLine(new string('-', 20));

        // 2-ий варіант
        List<KeyValuePair<int, decimal>> accountBalances2 = new List<KeyValuePair<int, decimal>>();
        accountBalances2.Add(new KeyValuePair<int, decimal>(1, 1000.50m));
        accountBalances2.Add(new KeyValuePair<int, decimal>(2, 2500.75m));
        Console.WriteLine("List<KeyValuePair<int, decimal>");
        foreach (var account in accountBalances2)
        {
            Console.WriteLine($"Рахунок {account.Key} - Доступна сума: {account.Value}");
        }
        Console.WriteLine(new string('-', 20));

        // 3-ій варіант
        SortedList<int, decimal> accountBalances3 = new SortedList<int, decimal>();
        accountBalances3.Add(1, 1000.50m);
        accountBalances3.Add(2, 2500.75m);
        Console.WriteLine("SortedList<int, decimal>");
        foreach (KeyValuePair<int, decimal> account in accountBalances3)
        {
            Console.WriteLine($"Рахунок {account.Key} - Доступна сума: {account.Value}");
        }
        Console.WriteLine(new string('-', 20));

        // 4-ий варіант
        SortedDictionary<int, decimal> accountBalances4 = new SortedDictionary<int, decimal>();
        accountBalances4.Add(1, 1000.50m);
        accountBalances4.Add(2, 2500.75m);
        Console.WriteLine("SortedDictionary<int, decimal>");
        foreach (KeyValuePair<int, decimal> account in accountBalances4)
        {
            Console.WriteLine($"Рахунок {account.Key} - Доступна сума: {account.Value}");
        }
    }
}