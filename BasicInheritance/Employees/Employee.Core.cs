using System;

namespace BasicInheritance.Employees
{
    public partial class Employee
    {
        // Field data.
        private string _empName;

        #region Ctors
        // Note use of constructor chaining.
        public Employee() { }
        public Employee(string name, int id, float pay)
          : this(name, 0, id, pay)
        { }

        public Employee(string name, int age, int id, float pay, string socialSecurityNumber) : this(name, age, id, pay)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
        }
        #endregion

        #region Properties 
        // Properties!
        public string Name
        {
            get => _empName;
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name length exceeds 15 characters");
                else
                    _empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties,
        // however there is no need to do so for this example.
        public int Id { get; set; }

        public float Pay { get; set; }

        public int Age { get; set; }

        public string SocialSecurityNumber { get; } = "";

        protected BenefitPackage EPackage = new BenefitPackage();

        #endregion
    }
}
