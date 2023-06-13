using System;

namespace Lab4.Models
{
    // Издатель
    public class Subscriber : IObservable
    {
        public Subscriber(string name)
        {
            Id = Interlocked.Increment(ref nextId);
            Name = name;
        }

        public void Fine(int amount)
        {
            Console.WriteLine($"You are fined for overdue. You must pay {amount}");
        }

        void IObservable.RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        void IObservable.RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(Id);
            }
        }

        private static int nextId;
        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Book> OwnedBooks { get; set; } = new List<Book>();
        private List<IObserver> observers = new();
    }

    interface IObserver
    {
        void Update(object o);
    }

    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
