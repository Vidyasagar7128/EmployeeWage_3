using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class ManageWages
    {
        List<int> wage = new List<int>();

        public void Manages()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"::::: {i}.PVT.LTD :::::");
                EmpWage empWage = new EmpWage();
                this.wage.Add(empWage.CalculateWage());
                empWage.ShowDetails();
            }
            foreach(int i in this.wage)
            {
                Console.WriteLine($"Saved Wage : {i}");
            }
        }
    }
}
