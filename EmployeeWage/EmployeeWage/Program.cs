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
            Console.WriteLine("Employee wage: " + EmployeeMaximumWageComputation());
        }

        static int EmployeeMaximumWageComputation()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empDays = 0;
            int empCheck = 0;
            int empType = 0;
            Random random = new Random();
            empType = random.Next(0, 2);
            if (empType == IS_FULL_TIME)
            {
                while (empHrs < 100 && empDays < 20)
                {
                    empCheck = random.Next(0, 2);
                    empDays = empDays + empCheck;
                    empHrs = empDays * 8;
                }
            }
            else
            {
                while (empHrs < 100 && empDays < 20)
                {
                    empCheck = random.Next(0, 2);
                    empDays = empDays + empCheck;
                    empHrs = empDays * 4;
                }
            }
            return EMP_RATE_PER_HOUR * empHrs;
        }
    }
}
