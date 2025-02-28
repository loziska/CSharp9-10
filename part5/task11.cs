using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = GCD(a, b);
        Console.WriteLine($"НОД чисел {a} и {b} равен: {gcd}");
    }

    // Рекурсивная функция для вычисления НОД
  static int GCD(int a, int b)
  {
      a = Math.Abs(a);
      b = Math.Abs(b);
  
      if (b == 0)
      {
          return a;
      }
  
      return GCD(b, a % b);
  }
}
