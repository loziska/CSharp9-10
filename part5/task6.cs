using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простые числа от 2 до 1000:");

        for (int i = 2; i <= 1000; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
    }

    // Метод для проверки числа на простоту
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }

        // Проверяем делители от 2 до квадратного корня из n
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
