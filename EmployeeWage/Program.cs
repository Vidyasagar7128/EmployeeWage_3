using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand = new Random().Next(0, 2);
            if (rand == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}
