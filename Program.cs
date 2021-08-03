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
            int Half_Day_Hour = 4;
            int Daily_Wage = 0;
            Random rand = new Random();
            int EmpCheck =rand.Next(0, 3);
            if (EmpCheck == 0)
            {
                Console.WriteLine("Employee is PresentFullDay");
                Daily_Wage = Wage_Per_Hour * Full_Day_Hour;
            }
            else if (EmpCheck == 1)
            {
                Console.WriteLine("Employee is PresentHalfDay");
                Daily_Wage = Wage_Per_Hour * Half_Day_Hour;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Total daily wage earned " + Daily_Wage);
        }
    }
}
