using System;

namespace BasicInheritance.Employees
{
    public partial class Employee
    {

        #region Class methods 
        public virtual void GiveBonus(float amount) => Pay += amount;

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

        public double GetBenefitCost() => EPackage.ComputePayDetection();

        #endregion
    }
}
