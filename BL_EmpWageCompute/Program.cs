namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            int randomInput = random.Next(0, 2);//0 or 1
            if (IS_PRESENT == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage per day:{0}", empWage);

        }
    }
}