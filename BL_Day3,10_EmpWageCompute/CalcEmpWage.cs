using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day3And10_EmpWageCompute
{
    internal class CalcEmpWage
    {
        const int EMP_RATE_PER_HR = 20;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_WORKING_HRS = 100;
        const int FULL_TIME = 1;
        const int PART_TIME = 2;

        int empHrs = 0;
        int empWage = 0;
        int totalWage = 0;
        int day = 1;
        int totalHrs = 0;

        public void CalcWage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            while (day <= MAX_WORKING_DAYS && totalHrs < MAX_WORKING_HRS)
            {
                int randomInput = random.Next(0, 3);//0 or 1 or 2
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Full time employee is present");

                        break;
                    case PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Part time employee is present");

                        break;
                        //default: //absent
                        //Console.WriteLine("Employee is absent");
                        //break;
                }
                empWage = EMP_RATE_PER_HR * empHrs; 
                totalWage += empWage; //totalWage =totalWage+empWage;
                totalHrs += empHrs;
                Console.WriteLine("Employee Wage for day{0}:{1}", day, empWage);
                day++;
            }
            Console.WriteLine("Total Wage for {0} days or {1} Hrs (Employee is allowed to work until eiter of max working days or max working hours is reached first) is {2}", (day - 1), totalHrs, totalWage);
        }
    }
}
