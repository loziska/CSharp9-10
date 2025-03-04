using System;

class Account
{
    // Поля класса
    public int Id { get; set; } // Уникальный номер сотрудника
    public string Login { get; set; } // Логин пользователя
    public string FullName { get; set; } // Полные ФИО сотрудника
    public int Age { get; set; } // Возраст сотрудника

    // Конструктор для инициализации полей
    public Account(int id, string login, string fullName, int age)
    {
        Id = id;
        Login = login;
        FullName = fullName;
        Age = age;
    }

    // Метод для вывода информации о сотруднике
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Логин: {Login}");
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine(); // Пустая строка для разделения
    }
}

class Program
{
    static void Main()
    {
        // Создаем несколько экземпляров класса Account
        Account employee1 = new Account(1, "ivanov_ii", "Иванов Иван Иванович", 30);
        Account employee2 = new Account(2, "petrov_pp", "Петров Петр Петрович", 25);
        Account employee3 = new Account(3, "sidorova_ss", "Сидорова Светлана Сергеевна", 28);

        // Выводим информацию о сотрудниках
        employee1.DisplayInfo();
        employee2.DisplayInfo();
        employee3.DisplayInfo();
    }
}
