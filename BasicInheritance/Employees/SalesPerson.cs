using System.Diagnostics.CodeAnalysis;

namespace BasicInheritance.Employees
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        //Пример правильного объявления конструктора дочернего класса
        //Ключевое слово Base ссылается на один из доступных конструкторов родительского класса
        //Такое объявление является правильным так как не создает пустых свойств родительского класса,
        //аргументы конструктора передаются напрямую в конструктор базового класса
        public SalesPerson(string fullName, int age, int empId, float currentPay, string ssn, int salesNumber)
            : base(fullName, age, empId, currentPay, ssn)
        {
            SalesNumber = salesNumber;
        }

        public override string ToString()
        {
            return "ID = " + Id + ", name = " + Name + ", Age = " + Age + ", Pay = " + Pay + ", SalesNumber = " +
                   SalesNumber;
        }
    }
}
