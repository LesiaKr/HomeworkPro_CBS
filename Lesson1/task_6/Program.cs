/*Завдання 6
Створіть метод, який як аргумент приймає масив цілих чисел і повертає колекцію квадратів усіх непарних чисел масиву. Для формування колекції використовуйте оператор yield.*/
public class Program
{
    public static IEnumerable<int> GetOddSquares(int[] numbers)
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                yield return number * number;
            }
        }
    }

    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        IEnumerable<int> oddSquares = GetOddSquares(numbers);

        Console.WriteLine("Квадрати непарних чисел:");
        foreach (int square in oddSquares)
        {
            Console.WriteLine(square);
        }
    }
}