namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to Employee Wage Computation Portal");
            Random random = new Random();
            int randomInput = random.Next(0, 2);//0 or 1
            if (IS_PRESENT == randomInput)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}