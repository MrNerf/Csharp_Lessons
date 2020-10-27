using System;
using System.Diagnostics.CodeAnalysis;

namespace BasicGeneric
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Person
    {
        #region fields

        private string _name;
        private int _age;
        private int _salary;


        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 15)
                    _name = value;
                else
                    Console.WriteLine("Имя не может быть больше 15 символов");
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 100 && value > 0)
                    _age = value;
                else
                    Console.WriteLine("Некорректный возраст");
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                    _salary = value;
                else
                    Console.WriteLine("Зарпалата не может быть меньше нуля");
            }
        }

        #endregion

        #region Constructors

        public Person() { }

        public Person(string name, int age) : this(name, age, 5000) { }

        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        #endregion

        #region Methods

        public void GiveBonus(int amount) => Salary += amount;

        #endregion

        public override string ToString()
        {
            return "Имя сотрудника " + _name + ", возраст сотрудника " + _age + ", зарплата сотрудника " + _salary;
        }
    }
}
