namespace BL_EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Portal");

            CompanyManager companyManager = new CompanyManager();
            companyManager.AddCompanyDetails("TataSteel", 30, 20, 140);
            companyManager.AddCompanyDetails("Sony", 40, 22, 160);
            companyManager.AddCompanyDetails("ITC", 33, 26, 170);

            foreach (CompanyDetails company in companyManager.listOfCompanies)
            {
                company.SetTotalEmpWage(WageCalculator.CalculateWageForCompany(company));
                //company.PrintDailyWages();
            }

            // Example usage of GetTotalWageByCompany method
            int totalWage = companyManager.GetTotalWageByCompany("TataSteel");
            Console.WriteLine("Total wage for TataSteel: {0}", totalWage);
        }
    }

    internal class WageCalculator
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        public static int CalculateWageForCompany(CompanyDetails obj)
        {
            int empHrs = 0;
            int totalWage = 0;
            int day = 1;
            int totalHrs = 0;
            Random random = new Random();
            while (day <= obj.noOfWorkingDays && totalHrs < obj.maxHrsPerMonth)
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                }
                int empWage = obj.empRatePerHour * empHrs;
                obj.dailyWages.Add(empWage);
                totalWage += empWage;
                totalHrs += empHrs;
                day++;
            }
            //Console.WriteLine("Compamy: {0}, Total Wage: {1}", obj.company, totalWage);
            return totalWage;
        }
    }
}