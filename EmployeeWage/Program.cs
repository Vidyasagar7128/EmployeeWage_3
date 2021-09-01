using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_HOUR = 20;
            int PART_TIME = 4;
            int salary;
            salary = PER_HOUR * PART_TIME;
            Console.WriteLine($"Salary is : {salary}");
            
        }
    }
}
