using System;
using System.Collections.Generic;

using System.Collections;
namespace EmployeeWage
{
    class ManageWages
    {
        ArrayList wage = new ArrayList();
        ArrayList wage1 = new ArrayList();

        public void Manages()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                EmpWage empWage = new EmpWage();
                this.wage.Add(empWage.CalculateWage(20));
                empWage.ShowDetails(i);
                empWage.ShowCompanySalary();
            }
            Console.WriteLine("*****************Second Company*******************");
            for (int j = 1; j <= number; j++)
            {
                EmpWage empWage1 = new EmpWage();
                this.wage1.Add(empWage1.CalculateWage(30));
                empWage1.ShowDetails(j);
                empWage1.ShowCompanySalary();
            }
            foreach (int i in this.wage)
            {
                Console.WriteLine($"Salary : {i}");///Wage of each company
            }
            Console.WriteLine("*****************Second Company*******************");
            foreach (int i in this.wage1)
            {
                Console.WriteLine($"Salary : {i}");///Wage of each company
            }
        }
    }
}
