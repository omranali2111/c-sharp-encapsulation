using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_encapsulation
{
    internal class Employee
    {
        /*
        Question # 3: Create a class called Employee that encapsulates the following private properties:

id(int)
name(string)
position(string)
salary(decimal)
Implement public methods to update the employee's position and salary,
        and provide getters to access the employee's information.
        */

        private int id;
        private string name;
        private string position;
        private decimal salary;

        public Employee(int id, string name, string position, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public void UpdatePosition(string newPosition)
        {
            position = newPosition;
        }

        public void UpdateSalary(decimal newSalary)
        {
            salary = newSalary;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPosition()
        {
            return position;
        }

        public decimal GetSalary()
        {
            return salary;
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Salary: " + salary);
        }

    }
}
