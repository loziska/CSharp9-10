using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        long iterResult = IterFactorial(n);
        long recResult = RecFactorial(n);

        Console.WriteLine($"Факториал числа {n} (итеративно): {iterResult}");
        Console.WriteLine($"Факториал числа {n} (рекурсивно): {recResult}");
    }

    // Итеративная функция для вычисления факториала
    static long IterFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        }

        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    // Рекурсивная функция для вычисления факториала
    static long RecFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        }

        if (n == 0 || n == 1)
        {
            return 1; // Базовый случай
        }

        return n * RecFactorial(n - 1); // Рекурсивный вызов
    }
}
