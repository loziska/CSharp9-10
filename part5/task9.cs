using System;

class Program
{
    static void Main()
    {
        // Примеры использования перегруженного метода
        double length1D = GetVectorLength(3.0); // Длина вектора в 1D
        double length2D = GetVectorLength(3.0, 4.0); // Длина вектора в 2D
        double length3D = GetVectorLength(3.0, 4.0, 5.0); // Длина вектора в 3D

        Console.WriteLine($"Длина вектора в 1D: {length1D:F2}");
        Console.WriteLine($"Длина вектора в 2D: {length2D:F2}");
        Console.WriteLine($"Длина вектора в 3D: {length3D:F2}");
    }

    // Метод для вычисления длины вектора в 1D
    static double GetVectorLength(double x)
    {
        return Math.Abs(x); // Длина вектора в 1D — это абсолютное значение координаты
    }

    // Метод для вычисления длины вектора в 2D
    static double GetVectorLength(double x, double y)
    {
        return Math.Sqrt(x * x + y * y); // Длина вектора в 2D
    }

    // Метод для вычисления длины вектора в 3D
    static double GetVectorLength(double x, double y, double z)
    {
        return Math.Sqrt(x * x + y * y + z * z); // Длина вектора в 3D
    }
}
