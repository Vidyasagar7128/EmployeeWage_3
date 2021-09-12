using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Companies you have : ");
            ManageWages manageWages = new ManageWages();
            manageWages.Manages();
        }
    }
}
