using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Тестирование класса Account ===");
        
        // 1. Тестирование конструкторов
        Console.WriteLine("\n1. Тестирование конструкторов:");
        var defaultAcc = new Account();
        Console.WriteLine($"Конструктор по умолчанию: {defaultAcc}");

        var paramAcc = new Account(-1, "test", "Тестовый Пользователь", 15, AccessRightsType.Manager);
        Console.WriteLine($"Параметризированный конструктор: {paramAcc}");
        Console.WriteLine($"Корректировка ID (-1→{paramAcc.Id}), возраста (15→{paramAcc.Age})");

        // 2. Тестирование методов инициализации
        Console.WriteLine("\n2. Тестирование методов инициализации:");
        var acc = new Account();
        
        acc.InitAdmin(1, "admin", "Администратор Системы", 35);
        Console.WriteLine($"InitAdmin: {acc}, IsAdmin: {acc.IsAdmin()}");

        acc.InitManager(2, "manager", "Менеджер Проекта", 28);
        Console.WriteLine($"InitManager: {acc}, IsManager: {acc.IsManager()}");

        // 3. Тестирование работы с ФИО
        Console.WriteLine("\n3. Тестирование работы с ФИО:");
        var nameAcc = new Account(3, "user", "Иванов Иван Иванович", 30, AccessRightsType.Staff);
        Console.WriteLine($"Полное: {nameAcc.FullName}");
        Console.WriteLine($"Фамилия: {nameAcc.GetLastName()}");
        Console.WriteLine($"Имя: {nameAcc.GetFirstName()}");
        Console.WriteLine($"Отчество: {nameAcc.GetPatronymic()}");

        // 4. Тестирование проверки прав доступа
        Console.WriteLine("\n4. Тестирование проверки прав доступа:");
        var testAcc = new Account();
        testAcc.InitGuest(4, "guest", "Гостевой Аккаунт", 20);
        
        Console.WriteLine($"Аккаунт: {testAcc}");
        Console.WriteLine($"IsGuest: {testAcc.IsGuest()}");
        Console.WriteLine($"IsAdult: {testAcc.IsAdult()}");
        Console.WriteLine($"AccessRights: {testAcc.GetAccessRightsType()}");
    }
}
