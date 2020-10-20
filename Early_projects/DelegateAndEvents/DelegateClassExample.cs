using System;
using System.Diagnostics.CodeAnalysis;

namespace DelegateAndEvents
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public static class DelegateClassExample
    {
        //void delegate
        private delegate void VoidDelegate();

        //value delegate
        private delegate int ValueDelegate(int value1, int value2);
        
        public static void ShowDelegateExample()
        {
            var random = new Random();

            //Void Delegate example
            Console.WriteLine("Void Delegate example");
            var voidDelegate = new VoidDelegate(VoidMethod);
            voidDelegate += VoidMethod;
            voidDelegate.Invoke();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            //Value Delegate example
            Console.WriteLine("Value Delegate example");
            ValueDelegate valueDelegate = Add;
            valueDelegate += Subtract;
            valueDelegate += Multiply;
            valueDelegate(random.Next(10, 50), random.Next(5, 10));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Delegate Action
            // Не возвращает значения, но способен принимать от 0 до 16 аргументов.
            // Action проще использовать вместо VoidDelegate
            Console.WriteLine("Void Action Delegate example");
            Action voidAction = VoidMethod;
            voidAction += VoidMethod;
            voidAction();
            Console.WriteLine("Value Action Delegate example");
            Action<int> valueAction = ValueMethod;
            valueAction(5);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Delegate Predicate
            // Возвращает значение типа bool, способен принимать 1 аргумент.
            Console.WriteLine("Predicate Delegate example");
            Predicate<int> predicate = PredicateMethod;
            Console.WriteLine(predicate(5));
            Console.WriteLine(predicate(100));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Func Predicate
            // Возвращает любое значение и принимает в себя до 16 аргументов, включая 0
            // Тип возвращаемого значения записывается в конце
            Console.WriteLine("Func Delegate example");
            Func<int, int, int> delegateFunc = Add;
            delegateFunc += Subtract;
            delegateFunc += Multiply;
            delegateFunc(random.Next(10, 30), random.Next(2, 5));
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        #region SubsidairyMethods

        private static void VoidMethod()
        {
            Console.WriteLine("Void Method");
        }

        private static int Add(int x, int y)
        {
            Console.WriteLine("Input parameters X = {0}, Y = {1}", x, y);
            Console.WriteLine("Add result: = {0}", x + y);
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            Console.WriteLine("Subtract result: = {0}", x - y);
            return x - y;
        }

        private static int Multiply(int x, int y)
        {
            Console.WriteLine("Multiply result: = {0}", x * y);
            return x * y;
        }

        private static void ValueMethod(int x)
        {
            Console.WriteLine("Value = {0}", x);
        }

        private static bool PredicateMethod(int value)
        {
            return value > 50;
        }
        #endregion
    }
}
