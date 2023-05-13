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
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            for (int day = 1; day <= MAX_WORKING_DAYS; day++)
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
                    default: //absent
                        empHrs = 0;
                        //Console.WriteLine("Employee is absent");
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage; //totalwage = totalWage + empWage;
                Console.WriteLine("Employee Wage per day{0}:{1}", day, empWage);
            }
            Console.WriteLine("Total wage for {0} days is {1}", MAX_WORKING_DAYS, totalWage);
        }
    }
}