/*Завдання 6
Створіть на диску 100 директорій із іменами від Folder_0 до Folder_99, потім видаліть їх.*/

using System.Text;

namespace OneHundredDir
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var directory = new DirectoryInfo(@"D:\навчання С#\Матеріали курсу C# для професіоналів-20250125\HomeworkPro_CBS\Lesson3\task_6");
            if (directory.Exists)
            {
                for (int i = 0; i < 100; i++)
                {
                    directory.CreateSubdirectory($"Folder_{i}");
                }
                Console.WriteLine("Директорії створено.");
                Console.WriteLine("\nНатисніть Enter, якщо готові видалити усі 100 директорій.\n");

                Console.ReadKey();

                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete(@$"D:\навчання С#\Матеріали курсу C# для професіоналів-20250125\HomeworkPro_CBS\Lesson3\task_6\Folder_{i}", true);
                }
                Console.WriteLine("Каталоги успішно видалені.");
            }
            else
            {
                Console.WriteLine("Директорія з ім'ям: {0} не існує.", directory.FullName);
                Directory.CreateDirectory(@"D:\навчання С#\Матеріали курсу C# для професіоналів-20250125\HomeworkPro_CBS\Lesson3\task_6");
            }

            Console.ReadKey();
        }
    }
}