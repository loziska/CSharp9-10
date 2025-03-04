using System;

class Program
{
    static void Main()
    {
        // Пример функции
        Func<double, double> f = x => (x * x) - (Math.Exp(x) / 2);

        // Ввод данных
        Console.Write("Введите начало отрезка a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите конец отрезка b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите точность error: ");
        double error = double.Parse(Console.ReadLine());

        // Вычисление корня
        try
        {
            double root = GetRoot(f, a, b, error);
            Console.WriteLine($"Корень уравнения: {root}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static double GetRoot(Func<double, double> f, double a, double b, double error)
    {
        // Проверка, что на отрезке есть корень
        if (f(a) * f(b) >= 0)
        {
            throw new Exception("На отрезке либо нет корня, либо их несколько.");
        }

        // Находим середину отрезка
        double c = (a + b) / 2;

        // Если достигнута требуемая точность, возвращаем c
        if (Math.Abs(f(c)) < error)
        {
            return c;
        }

        // Рекурсивно продолжаем поиск в соответствующей половине
        if (f(a) * f(c) < 0)
        {
            return GetRoot(f, a, c, error);
        }
        else
        {
            return GetRoot(f, c, b, error);
        }
    }
}
