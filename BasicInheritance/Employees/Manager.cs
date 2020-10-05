using System.Diagnostics.CodeAnalysis;

namespace BasicInheritance.Employees
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Manager : Employee
    {
        public int StockOptions { get; set; }
        //Пример правильного объявления конструктора дочернего класса
        //Ключевое слово Base ссылается на один из доступных конструкторов родительского класса
        //Такое объявление является правильным так как не создает пустых свойств родительского класса,
        //аргументы конструктора передаются напрямую в конструктор базового класса
        public Manager(string fullName, int age, int empId, float currentPay, string ssn, int stockOptions) 
            : base(fullName, age, empId, currentPay, ssn)
        {
            StockOptions = stockOptions;
        }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount * StockOptions);
        }

        public override string ToString()
        {
            return "ID = " + Id + ", name = " + Name + ", Age = " + Age + ", Pay = " + Pay + ", StockOptions = " +
                   StockOptions;
        }
    }
}
