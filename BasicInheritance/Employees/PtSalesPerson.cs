namespace BasicInheritance.Employees
{
    public sealed class PtSalesPerson: SalesPerson
    {
        public PtSalesPerson(string fullName, int age, int empId, float currentPay, string ssn, int salesNumber)
            : base(fullName, age, empId, currentPay, ssn, salesNumber) { }
        //Bla-Bla
    }
}
