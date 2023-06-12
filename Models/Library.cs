namespace Lab4.Models
{
    // Получатель команд
    public class Library
    {
        private Library() {}

        public void AddSub(Subscriber sub)
        {
            SubscribersList.AddSub(sub);
        }

        public void RemoveSub(Subscriber sub)
        {
            SubscribersList.RemoveSub(sub);
        }

        public bool IssueBook(string title, int userId)
        {
            var bookToIssue = TechDepartment.TakeABook(title);
            if (bookToIssue != null)
            {
                Librarian.IssueBook(userId, bookToIssue);
                return true;
            }
            
            bookToIssue = FictionDepartment.TakeABook(title);
            if (bookToIssue != null)
            {
                Librarian.IssueBook(userId, bookToIssue);
                return true;
            }

            Console.WriteLine("Book wasn't found in any department");
            return false;
        }

        public void ReturnBook(Book book)
        {
            Librarian.ReturnBook(book);

            if (book.Genre == Genre.Tech)
                TechDepartment.PutABook(book);
            else
                FictionDepartment.PutABook(book);
        }

        private static Library _instance = new();
        public static Library Instance { get { return _instance; } }

        private SubscribersList SubscribersList = SubscribersList.Instance;
        private Librarian Librarian = new();
        private TechDepartment TechDepartment = TechDepartment.Instance;
        private FictionDepartment FictionDepartment = FictionDepartment.Instance;
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
        string title;

        public IssueBookCommand(Library lib, int userId, string title)
        {
            Lib = lib;
            this.userId = userId;
            this.title = title;
        }
        public override void Execute()
        {
            var hasSucceded = Lib.IssueBook(title, userId);
            if (hasSucceded)
            {
                Console.WriteLine($"Successfully issued book {title} to abonent #{userId}");
            }
            else { Console.WriteLine("Book hasn't been issued"); }
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
}
