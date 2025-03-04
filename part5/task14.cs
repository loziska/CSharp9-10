using System;

class Program
{
    static void Main()
    {
        // Ввод значения x
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        // Проверка, что x не равно 0
        if (x == 0)
        {
            Console.WriteLine("Ошибка: x не может быть равен 0.");
            return;
        }

        // Ввод значения n
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        // Проверка, что n >= 0
        if (n < 0)
        {
            Console.WriteLine("Ошибка: n должно быть неотрицательным.");
            return;
        }

        // Вычисление суммы ряда
        double result = CalculateSeriesSum(x, n);

        // Вывод результата
        Console.WriteLine($"S({x}, {n}) = {result}");
    }

    static double CalculateSeriesSum(double x, int n, double currentTerm = 1.0, int k = 0)
    {
        // Базовый случай: если k > n, возвращаем 0
        if (k > n)
        {
            return 0;
        }

        // Рекурсивный случай: добавляем currentTerm к сумме и переходим к следующему члену
        return currentTerm + CalculateSeriesSum(x, n, currentTerm / x, k + 1);
    }
}
