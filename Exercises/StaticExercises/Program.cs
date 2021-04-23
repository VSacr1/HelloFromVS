using System;

namespace StaticExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RecruitmentList recruitmentList = new RecruitmentList();
            recruitmentList.CreateEmployee("Sarah", 80);
            recruitmentList.CreateEmployee("Bill", 1000); 
        }
    }

    class Employee
    {
        public Employee()
        {

        }
        public static int employeeCount = 0; 
        public Employee(string name, int employeeNumber)
        {
            this.Name = name;
            this.EmployeeNumber = employeeNumber; 
        }

        public string Name { get; set; }
        public int EmployeeNumber { get; set; }

        public void EmployeeCounter()
        {
            employeeCount++; 
        }
    }

    class RecruitmentList : Employee
    {
        static RecruitmentList()
        {
           
        }

        public void CreateEmployee(string name, int id)
        {
            Employee employee = new Employee(name, id);
            employee.EmployeeCounter();
            Console.WriteLine($"{employee.Name}, {Employee.employeeCount}"); 
        }
    }
}
