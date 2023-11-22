using System;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmp = new Employee();
            firstEmp.name = "Ensar";
            firstEmp.surname = "Erturk";
            firstEmp.no = 123123;
            firstEmp.department = "Computer";
            firstEmp.EmployeeInfo();
            Console.WriteLine("*********************************");

            Employee secondEmp = new Employee();
            secondEmp.name = "Furkan";
            secondEmp.surname = "Yildiz";
            secondEmp.no = 321321;
            secondEmp.department = "IK";
            secondEmp.EmployeeInfo();
        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public int no;
        public string department;
        
        public void EmployeeInfo() 
        {
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee Surname: {0}", surname);
            Console.WriteLine("Employee's No: {0}", no);
            Console.WriteLine("Employee Department: {0}", department);
        }
    }
}


