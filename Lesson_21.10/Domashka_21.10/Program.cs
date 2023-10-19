using System;

// Абстрактный класс человека
abstract class People
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Work();
    public abstract void DisplayInfo();
}

// Наследник 1 - "Сотрудник"
class Employee : People
{
    public string Position { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int age, string position, int salary)
    {
        Name = name;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public override void Work()
    {
        Console.WriteLine("Сотрудник:");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Должность: {Position}, Зарплата: {Salary}");
    }
}

// Наследник 2 - "Клиент"
class Client : People
{
    public string Company { get; set; }
    public string ContactInfo { get; set; }

    public Client(string name, int age, string company, string contactInfo)
    {
        Name = name;
        Age = age;
        Company = company;
        ContactInfo = contactInfo;
    }

    public override void Work()
    {
        Console.WriteLine("Клиент, который пользуется услугами бюро трудоустройства");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Компания: {Company}, Контактная информация: {ContactInfo}");
    }
}

// Наследник 3 - "Вакансия"
class Vacancy : People
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int Salary { get; set; }

    public Vacancy(string jobTitle, string company, int salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public override void Work()
    {
        Console.WriteLine("Вакансия открыта");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Должность: {JobTitle}, Компания: {Company}, Зарплата: {Salary}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Создание объектов классов
        Employee employee = new Employee("Иван", 30, "Менеджер", 50000);
        Client client = new Client("Анна", 25, "ACME Inc", "anna@gmail.com");
        Vacancy vacancy = new Vacancy("Разработчик", "Job Corp", 70000);

        // Вызов методов
        employee.Work();
        employee.DisplayInfo();

        client.Work();
        client.DisplayInfo();

        vacancy.Work();
        vacancy.DisplayInfo();

        Console.ReadKey();
    }
}

