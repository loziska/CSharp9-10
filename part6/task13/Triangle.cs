using System;

public class Triangle
{
    // Поля класса
    public double a;
    public double b;
    public double c;

    // Конструктор по умолчанию
    public Triangle()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    // Параметризированный конструктор
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // Переопределение метода ToString()
    public override string ToString()
    {
        return $"Стороны: a = {a}, b = {b}, c = {c}";
    }

    // Проверка, является ли фигура треугольником
    public bool IsTriangle()
    {
        return a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0;
    }

    // Получение типа треугольника
    public TriangleType GetTriangleType()
    {
        if (!IsTriangle())
            return TriangleType.NotTriangle;

        if (a == b && b == c)
            return TriangleType.Equilateral;

        if (a == b || a == c || b == c)
            return TriangleType.Isosceles;

        return TriangleType.Ordinary;
    }

    // Получение названия типа треугольника на русском
    public string GetTriangleTypeRus()
    {
        return GetTriangleType() switch
        {
            TriangleType.Equilateral => "равносторонний",
            TriangleType.Isosceles => "равнобедренный",
            TriangleType.Ordinary => "обыкновенный",
            _ => "не треугольник",
        };
    }

    // Получение периметра
    public double GetPerimeter()
    {
        return IsTriangle() ? a + b + c : 0;
    }

    // Получение площади (по формуле Герона)
    public double GetSquare()
    {
        if (!IsTriangle()) return 0;

        double p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Проверка, является ли треугольник прямоугольным
    public bool IsRight()
    {
        if (!IsTriangle()) return false;

        // Находим гипотенузу (самую большую сторону)
        double maxSide = Math.Max(a, Math.Max(b, c));

        // Проверяем теорему Пифагора
        if (maxSide == a)
            return Math.Abs(a * a - (b * b + c * c)) < 0.0001;
        else if (maxSide == b)
            return Math.Abs(b * b - (a * a + c * c)) < 0.0001;
        else
            return Math.Abs(c * c - (a * a + b * b)) < 0.0001;
    }
}
