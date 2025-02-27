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
    if (n == 2)
    {
        return true;
    }
    if (n % 2 == 0)
    {
        return false; // Все остальные четные числа не являются простыми
    }

    // Проверяем только нечетные делители
    for (int i = 3; i * i <= n; i += 2)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}
}
