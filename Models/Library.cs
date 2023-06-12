﻿namespace Lab4.Models
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

        private static Library _instance = new();
        public static Library Instance { get { return _instance; } }

        private SubscribersList SubscribersList = SubscribersList.Instance;
        private Librarian Librarian = new();
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
}
