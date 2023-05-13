namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            int randomInput = random.Next(0, 3);//0 or 1 or 3
            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Full time employee is present");

                    break;
                case PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Part time employee is present");

                    break;
                default: //absent
                    Console.WriteLine("Employee is absent");
                    break;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage per day:{0}", empWage);

        }
    }
}