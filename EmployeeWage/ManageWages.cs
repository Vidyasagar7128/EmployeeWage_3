using System;
using System.Collections.Generic;

using System.Collections;
namespace EmployeeWage
{
    class ManageWages
    {
        ArrayList wage = new ArrayList();
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
                Console.WriteLine($"Saved Wage from ArrayList : {i}");
            }
        }
    }
}
