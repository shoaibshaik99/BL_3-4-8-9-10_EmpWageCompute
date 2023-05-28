namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            CalcEmpWage CalculateWage = new CalcEmpWage();
            CalculateWage.CalcWage("TataSteel", 30, 20, 140);
            CalculateWage.CalcWage("Sony", 40, 22, 160);
        }

        internal class CalcEmpWage
        {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;

            public void CalcWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
            {
                int empHrs = 0;
                int totalWage = 0;
                int day = 1;
                int totalHrs = 0;
                //Console.WriteLine("Welcome to Employee Wage Computation Portal");
                Random random = new Random();
                while (day <= noOfWorkingDays && totalHrs < maxHrsPerMonth)
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
                    int empWage = empRatePerHour * empHrs;
                    totalWage += empWage; //totalWage =totalWage+empWage;
                    totalHrs += empHrs;
                    //Console.WriteLine("Employee Wage on day{0} for working {1}hrs is {2}", day, empHrs, empWage);
                    day++;
                }
                //Console.WriteLine(company + ": total Wage for {0} days or {1} Hrs (Employee is allowed to work until eiter of max working days or max working hours is reached first) is {2}", (day - 1), totalHrs, totalWage);
                Console.WriteLine("Compamy: {0}, Total Wage: {1}", company, totalWage);
            }
        }
    }
}
