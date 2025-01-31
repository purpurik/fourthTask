using System;

// Базовый класс "Сотрудник"
abstract class Employee
{
    public string Name { get; }
    public Employee(string name)
    {
        Name = name;
    }

    // Абстрактный метод для расчета зарплаты
    public abstract double CalculateSalary();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Сотрудник: {Name}, Зарплата: {CalculateSalary():C}");
    }
}

// Почасовой сотрудник
class HourlyEmployee : Employee
{
    private double hourlyRate;
    private int hoursWorked;

    public HourlyEmployee(string name, double hourlyRate, int hoursWorked)
        : base(name)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }
}

// Месячный сотрудник
class MonthlyEmployee : Employee
{
    private double monthlySalary;

    public MonthlyEmployee(string name, double monthlySalary)
        : base(name)
    {
        this.monthlySalary = monthlySalary;
    }

    public override double CalculateSalary()
    {
        return monthlySalary;
    }
}

// Контрактный сотрудник
class ContractEmployee : Employee
{
    private double contractAmount;

    public ContractEmployee(string name, double contractAmount)
        : base(name)
    {
        this.contractAmount = contractAmount;
    }

    public override double CalculateSalary()
    {
        return contractAmount;
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new HourlyEmployee("Иван", 15.5, 160);
        Employee emp2 = new MonthlyEmployee("Мария", 50000);
        Employee emp3 = new ContractEmployee("Алексей", 120000);

        emp1.DisplayInfo();
        emp2.DisplayInfo();
        emp3.DisplayInfo();
    }
}