using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        long result = Fibonacci(n);
        Console.WriteLine($"Число Фибоначчи F({n}) = {result}");
    }

    // Рекурсивная функция для вычисления числа Фибоначчи
    static long Fibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Число Фибоначчи определено только для неотрицательных чисел.");
        }

        if (n == 0)
        {
            return 0; // Базовый случай: F(0) = 0
        }

        if (n == 1)
        {
            return 1; // Базовый случай: F(1) = 1
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2); // Рекурсивный вызов
    }
}
