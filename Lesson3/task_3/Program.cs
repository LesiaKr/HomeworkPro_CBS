/*Завдання 3
Напишіть програму для пошуку заданого файлу на диску. Додайте код, який використовує клас FileStream і 
дозволяє переглядати файл у текстовому вікні. Насамкінець додайте можливість стиснення знайденого файлу.*/

using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public class FindFileCompress
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        var file = new FileInfo(@"D:\навчання С#\Матеріали курсу C# для професіоналів-20250125\HomeworkPro_CBS\Lesson3\task_3\Text.txt");

        if (file.Exists)
        {
            Console.WriteLine("Файл знайдено: " + file.FullName);

            FileStream fileStream = null;
            StreamReader reader = null;
            try
            {
                fileStream = file.OpenRead();
                reader = new StreamReader(fileStream);
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("Вміст файлу:");
                Console.WriteLine(fileContent);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (fileStream != null)
                    fileStream.Close();
            }

            string compressedFilePath = file.FullName + ".gz";
            FileStream originalFileStream = null;
            FileStream compressedFileStream = null;
            GZipStream compressionStream = null;
            try
            {
                originalFileStream = file.OpenRead();
                compressedFileStream = File.Create(compressedFilePath);
                compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);

                int theByte = originalFileStream.ReadByte();
                while (theByte != -1)
                {
                    compressionStream.WriteByte((byte)theByte);
                    theByte = originalFileStream.ReadByte();
                }

                Console.WriteLine("Файл стиснуто: " + compressedFilePath);
            }
            finally
            {
                if (compressionStream != null)
                    compressionStream.Close();
                if (compressedFileStream != null)
                    compressedFileStream.Close();
                if (originalFileStream != null)
                    originalFileStream.Close();
            }
        }
        else
        {
            Console.WriteLine("Файл не знайдено.");
        }
    }
}