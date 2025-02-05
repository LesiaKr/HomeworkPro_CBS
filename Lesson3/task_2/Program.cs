/*Завдання 2
Створіть файл, запишіть у нього довільні дані та закрийте файл. 
Потім знову відкрийте цей файл, прочитайте дані і виведіть їх на консоль.*/

using System.Text;

namespace WriteAndRead
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var file = new FileInfo(@"D:\навчання С#\Матеріали курсу C# для професіоналів-20250125\HomeworkPro_CBS\Lesson3\task_2\Text.txt");

            StreamWriter writer = file.CreateText();
            writer.WriteLine("Заголовок 1");
            writer.WriteLine("Тема: *********");
            writer.Write("Якийсь текст...");
            writer.Close();

            Console.WriteLine("Файл Text.txt створено і записаний текст.");

            StreamReader reader = file.OpenText();
            string fileContent = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine("Вміст файлу Text.txt:");
            Console.WriteLine(fileContent);

            Console.ReadKey();
        }
    }
}