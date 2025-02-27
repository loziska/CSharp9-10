using System;
using System.Numerics;

public static class Combinatorica
{
    // Метод для вычисления факториала
    public static BigInteger Factorial(int n)
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

    // Метод для вычисления количества комбинаций
    public static BigInteger Combo(int n, int m)
    {
        if (m > n || m < 0 || n < 0)
        {
            throw new ArgumentException("Некорректные значения n и m. Убедитесь, что m <= n и оба числа неотрицательны.");
        }

        return Factorial(n) / (Factorial(m) * Factorial(n - m));
    }

    // Метод для вычисления количества размещений
    public static BigInteger Accommodation(int n, int m)
    {
        if (m > n || m < 0 || n < 0)
        {
            throw new ArgumentException("Некорректные значения n и m. Убедитесь, что m <= n и оба числа неотрицательны.");
        }

        return Factorial(n) / Factorial(n - m);
    }
}
