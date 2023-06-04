namespace BL_EmployeeWageComputation
{
    internal class CompanyDetails
    {
        public string company;
        public int empRatePerHour, noOfWorkingDays, maxHrsPerMonth, totalWage;
        public List<int> dailyWages;

        public CompanyDetails(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
            this.dailyWages = new List<int>();
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalWage = totalEmpWage;
        }

        public void PrintDailyWages()
        {
            Console.WriteLine("Daily wages for {0}:", company);
            for (int i = 0; i < dailyWages.Count; i++)
            {
                Console.WriteLine("Day {0}: {1}", i + 1, dailyWages[i]);
            }
        }
    }
}