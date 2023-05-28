namespace BL_Day3And10_EmpWageCompute
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
    }
}