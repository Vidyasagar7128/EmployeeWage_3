using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Companies you have : ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                EmpWage empWage = new EmpWage();
                empWage.CalculateWage(i);
            }
        }
    }
}
