using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class ManageWages
    {
        EmpWage empWage = new EmpWage();
        List<int> wage = new List<int>();
        public void Manages()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                EmpWage empWage = new EmpWage();
                this.wage.Add(empWage.CalculateWage(i));
            }
            foreach(int i in this.wage)
            {
                Console.WriteLine($"Wage From List : {i}");
            }
        }
    }
}
