using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeMonthlyWageComputation());
        }

        static int EmployeeMonthlyWageComputation()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empDays = 0;
            int empCheck = 0;
            Random random = new Random();
            for (int day = 0; day < 20; day++)
            {
                empCheck = random.Next(0, 2);
                empDays = empDays + empCheck;
            }

            Console.WriteLine("No. of days worked :" + empDays);

            int empType = random.Next(0, 2);
            if (empType == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Full time Employee");
            }
            else
            {
                empHrs = 4;
                Console.WriteLine("Part time Employee");
            }
            return empHrs * empDays * EMP_RATE_PER_HOUR;
        }
    }
}
