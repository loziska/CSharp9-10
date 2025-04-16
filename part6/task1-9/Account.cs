using System;

public class Account
{
    public int Id { get; private set; }
    public string Login { get; private set; }
    public string FullName { get; private set; }
    public int Age { get; private set; }
    public AccessRightsType AccessRights { get; private set; }

    // Конструкторы
    public Account()
    {
        _SetData(0, "guest", "Неизвестный Пользователь", 18, AccessRightsType.Guest);
    }

    public Account(int id, string login, string fullName, int age, AccessRightsType accessRights)
    {
        _SetData(id, login, fullName, age, accessRights);
    }

    // Приватный метод для валидации и установки данных
    private void _SetData(int id, string login, string fullName, int age, AccessRightsType accessRights)
    {
        Id = id < 0 ? Math.Abs(id) : id;
        Login = string.IsNullOrEmpty(login) ? "guest" : login;
        FullName = string.IsNullOrEmpty(fullName) ? "Неизвестный Пользователь" : fullName;
        Age = age < 18 || age > 100 ? 18 : age;
        AccessRights = accessRights;
    }

    // Методы инициализации
    public void InitAccount(int id, string login, string fullName, int age, AccessRightsType accessRights)
    {
        _SetData(id, login, fullName, age, accessRights);
    }

    public void InitAdmin(int id, string login, string fullName, int age)
    {
        _SetData(id, login, fullName, age, AccessRightsType.Administrator);
    }

    public void InitManager(int id, string login, string fullName, int age)
    {
        _SetData(id, login, fullName, age, AccessRightsType.Manager);
    }

    public void InitEmployee(int id, string login, string fullName, int age)
    {
        _SetData(id, login, fullName, age, AccessRightsType.Staff);
    }

    public void InitGuest(int id, string login, string fullName, int age)
    {
        _SetData(id, login, fullName, age, AccessRightsType.Guest);
    }

    // Методы работы с ФИО
    public string GetLastName()
    {
        string[] nameParts = FullName.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return nameParts.Length > 0 ? nameParts[0] : string.Empty;
    }

    public string GetFirstName()
    {
        string[] nameParts = FullName.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return nameParts.Length > 1 ? nameParts[1] : string.Empty;
    }

    public string GetPatronymic()
    {
        string[] nameParts = FullName.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return nameParts.Length > 2 ? nameParts[2] : string.Empty;
    }

    // Методы проверки прав доступа
    public bool IsAdmin() => AccessRights == AccessRightsType.Administrator;
    public bool IsManager() => AccessRights == AccessRightsType.Manager;
    public bool IsEmployee() => AccessRights == AccessRightsType.Staff;
    public bool IsGuest() => AccessRights == AccessRightsType.Guest;

    // Дополнительные методы
    public bool IsAdult() => Age >= 18;

    public string GetAccessRightsType()
    {
        return AccessRights switch
        {
            AccessRightsType.Guest => "Гость",
            AccessRightsType.Staff => "Штатный сотрудник",
            AccessRightsType.Manager => "Менеджер",
            AccessRightsType.Administrator => "Администратор",
            _ => "Неизвестный уровень доступа"
        };
    }

    public override string ToString()
    {
        return $"Учётная запись: {Login} ({FullName}), возраст: {Age}, права: {GetAccessRightsType()}";
    }
}
