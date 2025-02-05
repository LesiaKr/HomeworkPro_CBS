/* Завдання 4 
Створіть текстовий файл-чек на кшталт «Найменування товару – 0.00(ціна)грн.» з певною кількістю найменувань товарів та датою 
здійснення покупки. Виведіть на екран інформацію з чека у форматі поточної локалі користувача та у форматі локалі en-US.*/
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        string filePath = "check.txt";
        string[] items = {
            "Хліб – 20.00 грн.",
            "Молоко – 25.50 грн.",
            "Яблука – 30.75 грн.",
            "Цукор – 15.00 грн.",
            "Кава – 50.00 грн."
        };
        DateTime purchaseDate = DateTime.Now;

        // Створюємо файл-чек
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine("Чек на покупку:");
        foreach (string item in items)
        {
            writer.WriteLine(item);
        }
        writer.WriteLine($"Дата покупки: {purchaseDate}");
        writer.Close();

        // Зчитуємо інформацію з файлу
        StreamReader reader = new StreamReader(filePath);
        string checkContent = reader.ReadToEnd();
        reader.Close();

        // Виводимо інформацію у форматі поточної локалі користувача
        Console.WriteLine("Інформація з чека у форматі поточної локалі користувача:");
        Console.WriteLine(checkContent);

        // Виводимо інформацію у форматі локалі en-US
        CultureInfo enUS = new CultureInfo("en-US");
        Console.WriteLine("\nІнформація з чека у форматі локалі en-US:");
        Console.WriteLine(checkContent.Replace("грн.", "UAH").Replace("Дата покупки:", "Purchase Date:"));
        Console.WriteLine($"Purchase Date: {purchaseDate.ToString(enUS)}");
    }
}
