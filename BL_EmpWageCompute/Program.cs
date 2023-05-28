namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
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
                Console.WriteLine("Employee Wage per day{0}:{1}", day, empWage);
                day++;
            }
            Console.WriteLine("Total Wage for {0} days and Hrs:{1} is {2}", (day - 1), totalHrs, totalWage);
        }
    }
}
