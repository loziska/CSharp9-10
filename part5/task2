using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        try
        {
            BigInteger combo = Combo(n, m);
            BigInteger accommodation = Accommodation(n, m);

            Console.WriteLine($"Количество комбинаций C({n}, {m}) = {combo}");
            Console.WriteLine($"Количество размещений A({n}, {m}) = {accommodation}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static BigInteger Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        BigInteger factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static BigInteger Combo(int n, int m)
    {
        if (m > n || m < 0 || n < 0)
        {
            throw new ArgumentException("Некорректные значения n и m. Убедитесь, что m <= n и оба числа неотрицательны.");
        }

        return Factorial(n) / (Factorial(m) * Factorial(n - m));
    }

    static BigInteger Accommodation(int n, int m)
    {
        if (m > n || m < 0 || n < 0)
        {
            throw new ArgumentException("Некорректные значения n и m. Убедитесь, что m <= n и оба числа неотрицательны.");
        }

        return Factorial(n) / Factorial(n - m);
    }
}
