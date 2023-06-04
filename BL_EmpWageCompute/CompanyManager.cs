namespace BL_EmployeeWageComputation
{
    internal class CompanyManager
    {
        public List<CompanyDetails> listOfCompanies;

        public CompanyManager()
        {
            listOfCompanies = new List<CompanyDetails>();
        }

        public void AddCompanyDetails(string company, int empRatePerHour, int noOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyDetails comp = new CompanyDetails(company, empRatePerHour, noOfWorkingDays, maxHrsPerMonth);
            listOfCompanies.Add(comp);
        }
    }
}