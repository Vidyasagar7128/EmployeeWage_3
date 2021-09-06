using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class EmpWage
    {
        int PER_HOUR = 20;
        int FULL_TIME = 8;
        int PART_TIME = 4;
        int salary;
        int totalSalary = 0;
        int WORKING_DAYS = 20;
        int WORKING_HRS = 100;
        int workDays = 0;
        int workHrs = 0;

        public void CalculateWage()
        {
            while (workDays < WORKING_DAYS && workHrs <= WORKING_HRS)
            {
                workDays++;
                int rand = new Random().Next(3);
                if (rand == 0)
                {
                    salary = FULL_TIME * PER_HOUR;
                    workHrs = workHrs + FULL_TIME;
                    totalSalary = totalSalary + salary;
                }
                else if (rand == 1)
                {
                    salary = PART_TIME * PER_HOUR;
                    workHrs = workHrs + PART_TIME;
                    totalSalary = totalSalary + salary;
                }
                else
                {
                    salary = 0;
                }
            }
            Console.WriteLine($"Total Salary : {totalSalary}");
            Console.WriteLine($"Total Days : {workDays}");
            Console.WriteLine($"Total Hours : {workHrs}");
        }
    }
}
