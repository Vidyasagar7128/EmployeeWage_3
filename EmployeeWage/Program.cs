using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_HOUR = 20;
            int FULL_TIME = 8;
            int salary;
            salary = PER_HOUR * FULL_TIME;
            Console.WriteLine($"Salary is : {salary}");
            
        }
    }
}
