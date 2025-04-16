using System;

class Program
{
    static void Main()
    {
        // Создаем массив треугольников
        Triangle[] triangles = new Triangle[]
        {
            new Triangle(3, 4, 5),
            new Triangle(5, 5, 5),
            new Triangle(4, 4, 6),
            new Triangle(1, 2, 3),
            new Triangle(5.5, 6.7, 8.9),
            new Triangle(0, 0, 0)
        };

        // Выводим информацию о каждом треугольнике
        foreach (var triangle in triangles)
        {
            Console.WriteLine(triangle.ToString());
            Console.WriteLine($"Тип: {triangle.GetTriangleTypeRus()}");
            Console.WriteLine($"Периметр: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь: {triangle.GetSquare():F2}");
            Console.WriteLine($"Прямоугольный: {(triangle.IsRight() ? "да" : "нет")}");
            Console.WriteLine();
        }
    }
}
