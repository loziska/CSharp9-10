using System;

class Program
{
    static void Main()
    {
        // Тестирование методов
        Console.Write("Введите количество строк (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (m): ");
        int m = int.Parse(Console.ReadLine());

        // Ввод матрицы
        double[,] matrix = InputMatrix(n, m);

        // Вывод матрицы
        Console.WriteLine("\nВведенная матрица:");
        PrintMatrix(matrix);

        // Вычисление суммы элементов матрицы
        double sum = GetMatrixSum(matrix);
        Console.WriteLine($"\nСумма элементов матрицы: {sum}");
    }

    // Метод для ввода матрицы
    static double[,] InputMatrix(int n, int m)
    {
        double[,] matrix = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введите элемент [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    // Метод для вывода матрицы
    static void PrintMatrix(double[,] matrix)
    {
        int n = matrix.GetLength(0); // Количество строк
        int m = matrix.GetLength(1); // Количество столбцов

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j],8:F2} "); // Форматированный вывод
            }
            Console.WriteLine();
        }
    }

    // Метод для вычисления суммы элементов матрицы
    static double GetMatrixSum(double[,] matrix)
    {
        double sum = 0;
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }
}
