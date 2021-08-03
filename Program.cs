using System;

namespace EmployeeWageComputationpr
{
    class Program
    {
   
        static void Main(string[] args)
        {
            //Daily_Wage = Wage_Per_Hour * Full_Day_Hour
            int Wage_Per_Hour = 20;
            int Full_Day_Hour = 8;
            int Daily_Wage = 0;
            Random rand = new Random();
            int EmpCheck =rand.Next(0, 2);
            if (EmpCheck == 0)
            {
                Console.WriteLine("Employee is Present");
                Daily_Wage = Wage_Per_Hour * Full_Day_Hour;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total daily wage earned " + Daily_Wage);
        }
    }
}
