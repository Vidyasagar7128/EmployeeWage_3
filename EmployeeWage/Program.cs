using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int PER_HOUR = 20;
            int FULL_TIME = 8;
            int PART_TIME = 4;
            int salary=0;
            int totalSalary=0;
            int WORKING_DAYS = 20;
            for(int i = 0; i <= WORKING_DAYS; i++)
            {
                int rand = new Random().Next(3);
                switch (rand)
                {
                    case 0:
                        salary = PER_HOUR* FULL_TIME;
                        totalSalary = totalSalary + salary;
                        Console.WriteLine($"Day {i} Salary : {salary}");
                        break;
                    case 1:
                        salary = PER_HOUR * PART_TIME;
                        totalSalary = totalSalary + salary;
                        Console.WriteLine($"Day {i} Salary : {salary}");
                        
                        break;
                    case 2:
                        salary = 0;
                        Console.WriteLine($"Day {i} Salary : {salary}");
                        break;
                    default: Console.WriteLine(".....");
                        break;
                }
                if (i == 20)
                {
                    Console.WriteLine($"20 Days Salary is : {totalSalary}");
                }
            }
            
            
        }
    }
}
