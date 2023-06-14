using Lab4.Models;

namespace Lab4.ViewModels
{
    // Инициатор команды
    public class MainViewModel
    {
        public MainViewModel() {}

        public void RegisterNewSub(string name)
        {
            Command = new AddSubCommand(Lib, new Subscriber(name));
            Command.Execute();
        }

        public void RemoveSub(int userId)
        {
            var subToRemove = SubList.FindSub(userId);
            if (subToRemove == null) { return; }

            Command = new RemoveSubCommand(Lib, subToRemove);
            Command.Execute();
        }

        public void IssueBook(int bookId, int userId)
        {
            Command = new IssueBookCommand(Lib, userId, bookId);
            Command.Execute();
        }

        public void ReturnBook(Book book)
        {
            Command = new ReturnBookCommand(Lib, book);
            Command.Execute();
        }

        public void Notify()
        {
            Command = new NotifySubCommand(Lib);
            Command.Execute();
        }

        public void AddSampleData()
        {
            Lib.AddSub(new Subscriber("Иван"));
            Lib.AddSub(new Subscriber("Даша"));

            var newBook = new Book(
                "Приключения барона Мюнхаузена",
                "Рудольф Э.Р.",
                new BookCard(),
                "2 полка 2 ряд",
                Genre.Fiction
            );
            var newBook2 = new Book(
                "Мефодий Буслаев",
                "Дмитрий Емец",
                new BookCard(),
                "4 полка 3 ряд",
                Genre.Fiction
            );
            var newBook3 = new Book(
                "Сборник сказок",
                "Пушкин А.С.",
                new BookCard(),
                "4 полка 3 ряд",
                Genre.Fiction
            );
            var newBook4 = new Book(
                "За всеми зайцами",
                "Дарья Донцова",
                new BookCard(),
                "3 полка 7 ряд",
                Genre.Fiction
            );
            var newBook5 = new Book(
                "Design Patterns",
                "GOF",
                new BookCard(),
                "10 полка 1 ряд",
                Genre.Tech
            );
            var newBook6 = new Book(
                "Экстремальное программирование",
                "Кент Бек",
                new BookCard(),
                "4 полка 12 ряд",
                Genre.Tech
            );
            var newBook7 = new Book(
                "Дизайн для недизайнеров",
                "Робин Уильямс",
                new BookCard(),
                "5 полка 13 ряд",
                Genre.Tech
            );
            var newBook8 = new Book(
                "Таня Гроттер",
                "Дмитрий Емец",
                new BookCard(),
                "3 полка 7 ряд",
                Genre.Fiction
            );
            var newBook9 = new Book(
                "Дневник Домового",
                "Евгений Чеширко",
                new BookCard(),
                "12 полка 7 ряд",
                Genre.Fiction
            );
            var newBook10 = new Book(
                "Сборник стихов",
                "Анна Ахматова",
                new BookCard(),
                "14 полка 1 ряд",
                Genre.Fiction
            );
            var newBook11 = new Book(
                "Гарри Поттер",
                "Джоан Роулинг",
                new BookCard(),
                "10 полка 1 ряд",
                Genre.Fiction
            );

            Lib.TechDepartment.PutABook(newBook5, newBook6, newBook7);
            Lib.FictionDepartment.PutABook(newBook, newBook2, newBook3, newBook4, newBook8, newBook9, newBook10, newBook11);
        }

        public int SubCount { get => SubList.SubCount; }
        public List<Subscriber> GetSubs => SubList.Subscribers;

        public List<Book> GetAllBooks {
            get
            {
                var allBooks = new List<Book>();
                allBooks.AddRange(Lib.FictionDepartment.Books);
                allBooks.AddRange(Lib.TechDepartment.Books);

                return allBooks;
            }
        }

        private Library Lib = Library.Instance;
        private SubscribersList SubList = SubscribersList.Instance;
        private Command? Command;
        public int selectedSub { get; set; } = -1;
        public int bookToTake { get; set; } = -1;
        public int bookToReturn { get; set; } = -1;
        public int notifiedSub { get => Lib.notifiedSub; }
    }
}
