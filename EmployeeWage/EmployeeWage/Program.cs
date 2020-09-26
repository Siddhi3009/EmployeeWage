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
            Console.WriteLine("Employee wage: " + EmployeeDailyWageComputation());
        }

        static int EmployeeDailyWageComputation()
        {
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //0. Full time present.
            //1. Part time present.
            //2. Absent
            switch(empCheck)
            {
                case 0:
                    empHrs = 8;
                    break;
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 0;
                    break;
                default:
                    break;
            }
            return empHrs * EMP_RATE_PER_HOUR;
        }
    }
}
