using System;

class Program
{
    static void Main()
    {
        // Запрашиваем ввод значения n у пользователя
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        // Проверяем, что n >= 1
        if (n < 1)
        {
            Console.WriteLine("Ошибка: n должно быть больше или равно 1.");
            return;
        }

        // Вычисляем частичную сумму
        double result = CalculatePartialSum(n);

        // Выводим результат
        Console.WriteLine($"S({n}) = {result}");
    }

    static double CalculatePartialSum(int n)
    {
        // Базовый случай: если n = 1, возвращаем 1
        if (n == 1)
        {
            return 1;
        }
        // Рекурсивный случай: добавляем 1/n^2 к сумме для n-1
        return CalculatePartialSum(n - 1) + 1.0 / (n * n);
    }
}
