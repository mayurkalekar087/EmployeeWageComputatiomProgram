using System;

namespace EmployeeWageComputationpr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int EmpCheck =rand.Next(0, 2);
            if (EmpCheck == 0)
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
