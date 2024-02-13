using System;

namespace EmployeeClass
{
    // define class employee
    class Employee
    {
        //attributes
        string name;
        int employeeId;
        string position;
        double salary;

        //constructor
        public Employee(string employeeName, int id, string employeePosition, double employeeSalary)
        {
            name = employeeName;
            employeeId = id;
            position = employeePosition;
            salary = employeeSalary;
        }

        //Method to get details of employee
        public void GetSalaryDetails()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Employee ID : " + employeeId);
            Console.WriteLine("Position : " + position);
            Console.WriteLine("Salary : " + salary);
        }
    }
}