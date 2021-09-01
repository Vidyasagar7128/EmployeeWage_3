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
            int salary;
            int rand = new Random().Next(2);
            salary = PER_HOUR * PART_TIME;
            switch (rand) {
                case 0 :
                    Console.WriteLine($"Full Time Salary : {PER_HOUR * FULL_TIME}");
                    break;
                case 1:
                    Console.WriteLine($"Part Time Salary : {PER_HOUR * PART_TIME}");
                    break;
            }
            
        }
    }
}
