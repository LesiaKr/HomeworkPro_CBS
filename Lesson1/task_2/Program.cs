/*Завдання 2
Створіть колекцію, в якій зберігалися б найменування 12 місяців, порядковий номер і кількість днів у відповідному місяці. Реалізуйте можливість вибору місяців як за порядковим номером, так і кількістю днів у місяці, при цьому результатом може бути не тільки один місяць.*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace MonthsYear
{
    class Program
    {
        static void Main()
        {
            Year year = new Year();

            Console.WriteLine("Months with 30 days:");
            foreach (var month in year.GetMonthsByDays(30))
            {
                Console.WriteLine($"{month.Name} ({month.Number})");
            }

            Console.WriteLine("\nMonth with number 5:");
            foreach (var month in year.GetMonthsByNumber(5))
            {
                Console.WriteLine($"{month.Name} ({month.Number})");
            }
        }
    }
}