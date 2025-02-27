using System;

class Program
{
    static void Main()
    {
        // Пример использования метода IsAmicable
        Console.Write("Введите первое число (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число (m): ");
        int m = int.Parse(Console.ReadLine());

        if (IsAmicable(n, m))
        {
            Console.WriteLine($"Числа {n} и {m} являются дружественными.");
        }
        else
        {
            Console.WriteLine($"Числа {n} и {m} не являются дружественными.");
        }
    }

    // Метод для вычисления суммы делителей числа (исключая само число)
    static int SumOfDivisors(int number)
{
    if (number < 1)
    {
        throw new ArgumentException("Число должно быть положительным.");
    }

    int sum = 1; // 1 является делителем для любого числа
    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
            if (i != number / i) // Добавляем парный делитель, если он не равен i
            {
                sum += number / i;
            }
        }
    }
    return sum;
}

    // Метод для проверки, являются ли числа дружественными
    static bool IsAmicable(int n, int m)
    {
        if (n == m)
        {
            return false; // Дружественные числа должны быть разными
        }

        return SumOfDivisors(n) == m && SumOfDivisors(m) == n;
    }
}
