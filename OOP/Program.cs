using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static private List<Employee> ListEmployees = new List<Employee>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Enter Employee Information");
                Console.WriteLine("2. Show List Employees");
                Console.WriteLine("3. Exit");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        enterEmployeeInformation();
                        break;
                    case "2":
                        Console.WriteLine("\n{0,-15} {1,-20} {2, -10}", "ID", "Name", "Salary");
                        showListEmployees();
                        Console.ReadLine();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("\nError, Please Repeat:");
                        Console.ReadLine();
                        break;
                }
            } while (true);
        }
        static private void enterEmployeeInformation()
        {
            string id, name;
            double salary;
            int workingHour;

            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary of 1 Hour: ");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Working Hour of Employee: ");
            workingHour = int.Parse(Console.ReadLine());

            Employee NewEmployee = new Employee(id, name, salary, workingHour);
            ListEmployees.Add(NewEmployee);

            Console.WriteLine("Enter to Continue");
            Console.ReadLine();
        }
        static private void showListEmployees()
        {
            foreach (Employee i in ListEmployees)
            {
                Console.WriteLine(i.ID.ToString() + "\t " + i.Name.ToString() + "\t " + i.SumSalary().ToString());
            }
        }

    }
}