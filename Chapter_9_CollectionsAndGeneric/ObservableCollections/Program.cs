using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ObservableCollections
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование Observable Collection";
            Console.ForegroundColor = ConsoleColor.Red;
            var people = new ObservableCollection<Person>
            {
                new Person("Peter", 25),
                new Person("Jade", 24)
            };
            people.CollectionChanged += People_CollectionChanged;
            Console.WriteLine("Подписались на событие об изменении коллекции");
            Console.WriteLine();
            people.Add(new Person("Adam", 50));
            Console.WriteLine();
            Console.WriteLine("Удалим элемент");
            people.RemoveAt(1);
            Console.ReadLine();
        }

        private static void People_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"В коллекции произошло событие: Event {e.Action}");
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                {
                    Console.WriteLine("Новый элемент");
                    foreach (var eNewItem in e.NewItems)
                    {
                        Console.WriteLine(eNewItem.ToString());
                    }
                    break;
                }
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Старый элемент");
                    foreach (var eOldItem in e.OldItems)
                    {
                        Console.WriteLine(eOldItem.ToString());
                    }

                    Console.WriteLine();
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
