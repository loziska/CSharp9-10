using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        // Вывод факториалов чисел от 0 до n
        Console.WriteLine("\nФакториалы чисел от 0 до n:");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"{i}! = {Combinatorica.Factorial(i)}");
        }

        // Вывод треугольника сочетаний (треугольника Паскаля)
        Console.WriteLine("\nТреугольник сочетаний (треугольник Паскаля):");
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{Combinatorica.Combo(i, j)} ");
            }
            Console.WriteLine();
        }

        // Вывод треугольника размещений
        Console.WriteLine("\nТреугольник размещений:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{Combinatorica.Accommodation(i, j)} ");
            }
            Console.WriteLine();
        }
    }
}
