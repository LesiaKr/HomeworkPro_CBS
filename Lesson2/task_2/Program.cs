/*Завдання 2
Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції. 
З колекції можна отримувати категорії товарів, які купив покупець або за категорією визначити покупців.*/

using System.Collections.Specialized;
using System.Text;

namespace MyCustomerCategory
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var customerCategory = new NameValueCollection
                                         {
                                              {"Олег Іванів", "Дрібна побутова техніка"},
                                              {"Олег Іванів", "Велика побутова техніка"},
                                              {"Назар Петрів", "Мобільні телефони"},
                                              {"Тарас Дутка", "Ноутбуки"},
                                              {"Тарас Дутка", "Техніка для кухні"},
                                              {"Ольга Дубок", "Ноутбуки"},
                                              {"Наталя Тарасів", "Ноутбуки"}
                                         };

            string customerToFind = "Тарас Дутка";
            Console.WriteLine($"Покупець {customerToFind} знайдений у категоріях: " + customerCategory.Get(customerToFind));

            Console.WriteLine(new string('-', 20));
            string categoryToFind = "Ноутбуки";
            Console.WriteLine("Категорія: " + categoryToFind);
            foreach (string key in customerCategory.AllKeys)
            {
                if (customerCategory.GetValues(key).Contains(categoryToFind))
                {
                    Console.WriteLine("Покупець: " + key);
                }
            }
            Console.ReadKey();
        }
    }
}