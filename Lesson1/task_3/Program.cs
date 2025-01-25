/*Завдання 3 
Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево» (ім'я людини, рік народження), причому до неї можна додавати/вилучати нового родича, є можливість побачити всіх спадкоємців обраної людини, відібрати родичів за роком народження. */

namespace FamilyTree
{
    class Program
    {
        static void Main()
        {
            FamilyTree family = new FamilyTree();

            Console.WriteLine("Name: ");
            foreach (var name in family.GetByName("Alex"))
            {
                Console.WriteLine($"{name.Name} ({name.YearBrth})");
            }

            Console.WriteLine("Relatives: ");
            foreach (var relative in family)
            {
                Console.WriteLine($"{relative.Name} ({relative.YearBrth})");
            }

            Console.WriteLine("\n:Year: ");
            foreach (var year in family.GetByYear(1992))
            {
                Console.WriteLine($"{year.YearBrth} ({year.Name})");
            }

            Relative newRelative = new Relative("Lesia", 1992);
            family.Add(newRelative);

            Console.WriteLine("\nAfter adding new relative:");
            foreach (var relative in family)
            {
                Console.WriteLine($"{relative.Name} ({relative.YearBrth})");
            }

            Console.WriteLine("\n:Year: ");
            foreach (var year in family.GetByYear(1992))
            {
                Console.WriteLine($"{year.YearBrth} ({year.Name})");
            }

            family.Remove(newRelative);
            Console.WriteLine("\nAfter removing new relative:");
            foreach (var relative in family)
            {
                Console.WriteLine($"{relative.Name} ({relative.YearBrth})");
            }
        }
    }
}
