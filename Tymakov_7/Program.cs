using System;

// Перечисление видов банковского счета
enum Type
{
    Now,
    Sber
}

// Класс Счет в банке
class BankAccount_2
{
    private static int nextAccountNumber = 1; // Статическая переменная для генерации номера счета
    private int accountNumber; // Номер счета
    private decimal balance; // Баланс
    private Type accountType; // Тип счета

    // Конструктор класса, генерирующий уникальный номер счета
    public BankAccount_2()
    {
        accountNumber = nextAccountNumber;
        nextAccountNumber++;
        balance = 0;
        accountType = Type.Now;
    }
    public void SetAccountData(int number, decimal Balance, Type type)
    {
        accountNumber = number;
        balance = Balance;
        accountType = type;
    }

    // Метод для доступа к номеру счета
    public int GetAccountNumber()
    {
        return accountNumber;
    }

    // Метод для доступа к балансу
    public decimal GetBalance()
    {
        return balance;
    }

    // Метод для доступа к типу счета
    public Type GetAccountType()
    {
        return accountType;
    }

    // Метод для установки значения баланса
    public void SetBalance(decimal newBalance)
    {
        balance = newBalance;
    }

    // Метод для вывода информации о счете
    public void PrintAccountInfo_2()
    {
        Console.WriteLine("Номер счета: " + accountNumber);
        Console.WriteLine("Баланс: " + balance);
        Console.WriteLine("Тип счета: " + accountType);
    }
    public bool TakeOff(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TakeOn(decimal canTakeOn)
    {
        balance += canTakeOn;
    }
}

// Класс с информации о здании
class Building
{
    private static int lastBuildingNumber = 76;

    private int buildingNumber;
    private int height;
    private int floors;
    private int apartments;
    private int entrances;

    public Building(int height, int floors, int apartments, int entrances)
    {
        lastBuildingNumber++;
        buildingNumber = lastBuildingNumber;
        this.height = height;
        this.floors = floors;
        this.apartments = apartments;
        this.entrances = entrances;
    }

    public int GetBuildingNumber()
    {
        return buildingNumber;
    }

    public int GetHeight()
    {
        return height;
    }

    public int GetFloors()
    {
        return floors;
    }

    public int GetApartments()
    {
        return apartments;
    }

    public int GetEntrances()
    {
        return entrances;
    }

    public double CalculateFloorHeight()
    {
        return (double)height / floors;
    }

    public double CalculateApartmentsPerEntrance()
    {
        return (double)apartments / entrances;
    }

    public double CalculateApartmentsPerFloor()
    {
        return (double)apartments / floors;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Упр 7.1");
        Console.WriteLine("Вывод банковского счёта");
        // Создание объекта класса и заполнение его полей
        BankAccount_2 account = new BankAccount_2();
        account.SetAccountData(77777, 1100.50m, Type.Now);

        // Вывод информации о счете
        account.PrintAccountInfo_2();
        Console.WriteLine();

        Console.WriteLine("Упр 7.2");
        Console.WriteLine("Вывод банковского счёта");
        BankAccount_2 account1 = new BankAccount_2();
        account1.SetBalance(1000.50m);

        BankAccount_2 account2 = new BankAccount_2();
        account2.SetBalance(5000.75m);

        Console.WriteLine("Информация о счете 2:");
        account1.PrintAccountInfo_2();

        Console.WriteLine();

        Console.WriteLine("Информация о счете 3:");
        account2.PrintAccountInfo_2();

        Console.WriteLine("Упр 7.3");
        Console.WriteLine("Снять или положить деньги на стол");
        Console.WriteLine();
        Console.WriteLine("Сколько вы хотите снять со счёта");
        decimal amount;
        // Снятие со счёта
        bool succes = decimal.TryParse(Console.ReadLine(), out amount);
        if (succes)
        {
            bool canTakeOff = account1.TakeOff(amount);

            if (canTakeOff)
            {
                Console.WriteLine("\nВы сняли со счета " + amount + " рублей.");
            }
            else
            {
                Console.WriteLine("\nНедостаточно средств на счете.");
            }
            Console.WriteLine("Баланс счета 2 после снятия средств: " + account1.GetBalance());
        }


        // Положить на счет
        decimal canTakeOn;
        bool succes_1 = decimal.TryParse(Console.ReadLine(), out canTakeOn);
        if (succes_1)
        {
            account1.TakeOn(canTakeOn);
        }
        Console.WriteLine("Баланс счета 2 после пополнения средств: " + account1.GetBalance());
        Console.WriteLine();


        Console.WriteLine("Дз 7.1");
        Console.WriteLine("Тех.карта здания");
        Building building1 = new Building(80, 50, 100, 4);
        Console.WriteLine($"Номер здания: {building1.GetBuildingNumber()}");
        Console.WriteLine($"Высота: {building1.GetHeight()}");
        Console.WriteLine($"Кол-во этажей: {building1.GetFloors()}");
        Console.WriteLine($"Кол-во квартир: {building1.GetApartments()}");
        Console.WriteLine($"Кол-во подъездов: {building1.GetEntrances()}");
        Console.WriteLine($"Высота этажа: {building1.CalculateFloorHeight()}");
        Console.WriteLine($"Квартир в подъезде: {building1.CalculateApartmentsPerEntrance()}");
        Console.WriteLine($"Квартир на этаже: {building1.CalculateApartmentsPerFloor()}");
        Console.Read();
    }
}