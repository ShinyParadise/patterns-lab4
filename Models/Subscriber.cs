namespace Lab4.Models
{
    // Подписчик
    public class Subscriber
    {
        public Subscriber(string name)
        {
            Id = Interlocked.Increment(ref nextId);
            Name = name;
        }
        private static int nextId;
        public int Id { get; private set; }
        public string Name { get; set; }
        public List<Book> OwnedBooks { get; set; } = new List<Book>();

        public void Fine(int amount)
        {
            Console.WriteLine($"You are fined for overdue. You must pay {amount}");
        }
    }
}
