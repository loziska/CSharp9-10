using System;
using System.Numerics; // Необходимо подключить пространство имен

class Program
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число: ");
        int n = int.Parse(Console.ReadLine());

        try
        {
            BigInteger result = Factorial(n);
            Console.WriteLine($"Факториал числа {n} равен {result}");
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
}
