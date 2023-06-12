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

        public void IssueBook(string title, int userId)
        {
            Command = new IssueBookCommand(Lib, userId, title);
            Command.Execute();
        }

        public void ReturnBook(Book book)
        {
            Command = new ReturnBookCommand(Lib, book);
            Command.Execute();
        }

        public void AddSampleData()
        {
            SubList.AddSub(new Subscriber("Иван"));
            SubList.AddSub(new Subscriber("Даша"));
        }

        public int SubCount { get => SubList.SubCount; }
        public List<Subscriber> GetSubs => SubList.Subscribers;

        private Library Lib = Library.Instance;
        private SubscribersList SubList = SubscribersList.Instance;
        private Command? Command;
        public string NewSubName { get; set; } = "";
    }
}
