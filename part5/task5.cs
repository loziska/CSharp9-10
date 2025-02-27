using System;

class Program
{
    static void Main()
    {
        // Пример использования методов
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Число {number} четное: {IsEven(number)}");
        Console.WriteLine($"Число {number} нечетное: {IsOdd(number)}");
    }

    static bool IsEven(int n) => n % 2 == 0;

    static bool IsOdd(int n) => n % 2 != 0;
}
