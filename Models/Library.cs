namespace Lab4.Models
{
    // Получатель команд
    public class Library
    {
        private Library()
        {
            SubscribersList = SubscribersList.Instance;
            Librarian = new();

            foreach (Subscriber sub in SubscribersList.Subscribers)
            {
                sub.RegisterObserver(Librarian);
            }
        }

        public void AddSub(Subscriber sub)
        {
            SubscribersList.AddSub(sub);
            sub.RegisterObserver(Librarian);
        }

        public void RemoveSub(Subscriber sub)
        {
            sub.RemoveObserver(Librarian);
            SubscribersList.RemoveSub(sub);
        }

        public void IssueBook(int bookId, int userId)
        {
            Book? book = TechDepartment.TakeABook(bookId);
            if (book == null) { book = FictionDepartment.TakeABook(bookId); }
            if (book == null) {  return; }

            Librarian.IssueBook(userId, book);
        }

        public void ReturnBook(Book book)
        {
            Librarian.ReturnBook(book);

            if (book.Genre == Genre.Tech)
                TechDepartment.PutABook(book);
            else
                FictionDepartment.PutABook(book);
        }

        public void Notify()
        {
            notifiedSub = 0;
            SubscribersList.Subscribers.ForEach(s => {
                if (s.OwnedBooks.Count > 0)
                {
                    s.NotifyObservers();
                    notifiedSub++;
                }
            });
        }

        private static Library? _instance;
        public static Library Instance
        {
            get
            { 
                if (_instance == null)
                    _instance = new Library();
                return _instance;
            }
        }

        private SubscribersList SubscribersList;
        private Librarian Librarian;
        public int notifiedSub { get; private set; } = 0;
        public TechDepartment TechDepartment { get; private set; } = TechDepartment.Instance;
        public FictionDepartment FictionDepartment { get; private set; } = FictionDepartment.Instance;
    }

    // Абстрактная команда
    public abstract class Command
    {
        public abstract void Execute();
    }

    // Конкретные команды
    public class AddSubCommand : Command
    {
        Library Lib;
        Subscriber Subscriber;

        public AddSubCommand(Library lib, Subscriber sub)
        {
            Lib = lib;
            Subscriber = sub;
        }
        public override void Execute()
        {
            Lib.AddSub(Subscriber);
            Console.WriteLine("Added new sub");
        }
    }

    public class RemoveSubCommand : Command
    {
        Library Lib;
        Subscriber Subscriber;

        public RemoveSubCommand(Library lib, Subscriber sub)
        {
            Lib = lib;
            Subscriber = sub;
        }
        public override void Execute()
        {
            Lib.RemoveSub(Subscriber);
            Console.WriteLine("Removed sub");
        }
    }

    public class IssueBookCommand : Command
    {
        Library Lib;
        int userId;
        int bookId;

        public IssueBookCommand(Library lib, int userId, int bookId)
        {
            Lib = lib;
            this.userId = userId;
            this.bookId = bookId;
        }
        public override void Execute()
        {
            Lib.IssueBook(bookId, userId);
        }
    }

    public class ReturnBookCommand : Command
    {
        Library Lib;
        Book book;

        public ReturnBookCommand(Library lib, Book book)
        {
            Lib = lib;
            this.book = book;
        }
        public override void Execute()
        {
            Lib.ReturnBook(book);
            Console.WriteLine($"Book {book.Title} was returned");
        }
    }

    public class NotifySubCommand : Command
    {
        Library Lib;

        public NotifySubCommand(Library lib)
        {
            Lib = lib;
        }

        public override void Execute()
        {
            Lib.Notify();
        }
    }
}
