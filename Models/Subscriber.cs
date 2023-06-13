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
            MessageBox.Show($"{Name}: Верните книгу поскорее, иначе вам придется заплатить штраф в размере {amount} рублей");
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
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

    public interface IObserver
    {
        public void Update(object o);
    }

    public interface IObservable
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
}
