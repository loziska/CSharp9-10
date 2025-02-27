using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Примеры использования метода GetMean
        Console.WriteLine($"Среднее значение: {GetMean(1, 2, 3, 4, 5)}"); // Передаем несколько чисел
        Console.WriteLine($"Среднее значение: {GetMean(10, 20, 30)}");    // Передаем три числа
        Console.WriteLine($"Среднее значение: {GetMean()}");              // Без параметров
    }

    // Метод для вычисления среднего значения
    static double GetMean(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0; // Если параметры не переданы, возвращаем 0
        }

        return numbers.Average(); // Используем метод Average() для вычисления среднего
    }
}
