using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmp = new Employee("Ensar", "Erturk", 123123, "Computer");
            firstEmp.EmployeeInfo();
            Console.WriteLine("*********************************");

            Employee secondEmp = new Employee("Furkan", "Yildiz", 321321, "IK");
            secondEmp.EmployeeInfo();
        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;

        public Employee(string name, string surname, int no, string department) {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.department = department;
        }

        public void EmployeeInfo() 
        {
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee Surname: {0}", surname);
            Console.WriteLine("Employee's No: {0}", no);
            Console.WriteLine("Employee Department: {0}", department);
        }
    }
}
