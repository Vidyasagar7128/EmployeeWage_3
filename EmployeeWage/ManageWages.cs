﻿using System;
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
                EmpWage empWage = new EmpWage();
                this.wage.Add(empWage.CalculateWage());
                empWage.ShowDetails();
                empWage.ShowCompanySalary(i);
            }
        }
    }
}