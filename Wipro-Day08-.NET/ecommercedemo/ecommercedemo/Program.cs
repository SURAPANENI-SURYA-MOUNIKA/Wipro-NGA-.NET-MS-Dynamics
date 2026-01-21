// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// Delegate definition
delegate void EmployeePromotionHandler(Employee emp);

class Employee
{
    // Private fields
    private int id;
    private string name;
    private double salary;

    // Property for ID
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    // Property for Name
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                name = "Unknown";
        }
    }

    // Property for Salary
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
                salary = value;
            else
                salary = 0;
        }
    }

    // Constructor
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    // Method to display employee details
    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}");
    }
}

// Employee Manager with Indexer
class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();

    // Add employee
    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    // Indexer to access employees by index
    public Employee this[int index]
    {
        get
        {
            if (index >= 0 && index < employees.Count)
                return employees[index];
            else
                return null;
        }
        set
        {
            if (index >= 0 && index < employees.Count)
                employees[index] = value;
        }
    }

    // Count of employees
    public int Count
    {
        get { return employees.Count; }
    }
}

class Program
{
    // Delegate method
    static void PromoteEmployee(Employee emp)
    {
        emp.Salary *= 1.1; // 10% raise
        Console.WriteLine($"{emp.Name} has been promoted! New Salary: {emp.Salary}");
    }

    static void Main(string[] args)
    {
        // Create EmployeeManager
        EmployeeManager manager = new EmployeeManager();

        // Create Employees
        Employee emp1 = new Employee(101, "Alice", 50000);
        Employee emp2 = new Employee(102, "Bob", 60000);
        Employee emp3 = new Employee(103, "Charlie", 55000);

        // Add employees
        manager.AddEmployee(emp1);
        manager.AddEmployee(emp2);
        manager.AddEmployee(emp3);

        // Access employees using indexer
        Console.WriteLine("Employees in the system:");
        for (int i = 0; i < manager.Count; i++)
        {
            manager[i].Display();
        }

        // Delegate example
        EmployeePromotionHandler promotion = new EmployeePromotionHandler(PromoteEmployee);

        // Promote an employee using delegate
        Console.WriteLine("\nPromoting Bob:");
        promotion(manager[1]); // Promotes Bob
    }
}
