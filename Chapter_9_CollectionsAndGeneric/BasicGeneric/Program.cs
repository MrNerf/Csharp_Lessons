using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BasicGeneric
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Базовые обобщения";
            Console.ForegroundColor = ConsoleColor.Cyan;
            UseList();
            Console.WriteLine();
            UseStack();
            Console.WriteLine();
            UseQueue();
            Console.WriteLine();
            UseDictionary();
            Console.ReadLine();
        }

        #region Methods in System.Collections.Generic

        private static void UseList()
        {
            var people = new List<Person>()
            {
                new Person("Homer", 25),
                new Person("Marge", 24),
                new Person("Bart", 10),
                new Person("Lisa", 11)
            };

            Console.WriteLine($"Количество элементов в списке {people.Count}");
            Console.WriteLine();
            foreach (var person in people) Console.WriteLine(person);
            Console.WriteLine();
            Console.WriteLine("Добавление к коллекции");
            people.Insert(2, new Person("Magie", 2, 1000));
            Console.WriteLine($"Количество элементов в списке {people.Count}");
            Console.WriteLine();
            var personArray = people.ToArray();
            foreach (var person in personArray) Console.WriteLine(person);
        }

        private static void UseStack()
        {
            Console.WriteLine("Стек работает по принципу LIFO");
            var stackPeople = new Stack<Person>();
            stackPeople.Push(new Person("Homer", 25));
            stackPeople.Push(new Person("Marge", 24));
            stackPeople.Push(new Person("Bart", 10));
            stackPeople.Push(new Person("Lisa", 11));

            Console.WriteLine($"Первая персона в стеке {stackPeople.Peek()} без вытаскивания из очереди");
            try
            {
                Console.WriteLine($"Вытаскиваем из стека верхний элемент {stackPeople.Pop()}");
                Console.WriteLine($"Вытаскиваем из стека верхний элемент {stackPeople.Pop()}");
                Console.WriteLine($"Вытаскиваем из стека верхний элемент {stackPeople.Pop()}");
                Console.WriteLine($"Вытаскиваем из стека верхний элемент {stackPeople.Pop()}");
                Console.WriteLine($"Вытаскиваем из стека верхний элемент {stackPeople.Pop()}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.Name} got coffee");
        }

        private static void UseQueue()
        {
            Console.WriteLine("Очередь работает по принципу FIFO");
            var stackPeople = new Queue<Person>();
            stackPeople.Enqueue(new Person("Homer", 25));
            stackPeople.Enqueue(new Person("Marge", 24));
            stackPeople.Enqueue(new Person("Bart", 10));
            stackPeople.Enqueue(new Person("Lisa", 11));

            Console.WriteLine($"Первая персона в очереди {stackPeople.Peek()} без вытаскивания из стека");
            try
            {
                GetCoffee(stackPeople.Dequeue());
                GetCoffee(stackPeople.Dequeue());
                GetCoffee(stackPeople.Dequeue());
                GetCoffee(stackPeople.Dequeue());
                GetCoffee(stackPeople.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void UseDictionary()
        {
            var people = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person("Homer", 25),
                ["Marge"] = new Person("Marge", 24),
                ["Bart"] = new Person("Bart", 10),
                ["Lisa"] = new Person("Lisa", 11)
            };
            try
            {
                var homer = people["Homer"];
                Console.WriteLine(homer);
                homer = people["Marta"];
                Console.WriteLine(homer);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

    }
}
