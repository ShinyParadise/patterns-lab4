namespace Lab4.Models
{
    public delegate void Del(object o);

    // Издатель
    public class Librarian
    {
        public void IssueBook(int userId, Book book)
        {
            var sub = SubscribersList[userId];
            var issueDate = DateTime.Now;
            var dueDate = issueDate.AddDays(14);

            book.Card.WriteIssueNotes(sub, issueDate, dueDate);
            sub.OwnedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            Subscriber? sub = book.Card.Sub;
            sub?.OwnedBooks.Remove(book);
            book.Card.ReturnBook();
        }

        public void RegisterSub(Del d)
        {
            Delegates += d;
        }

        public void UnregisterSub(Del d)
        {
            if (Delegates == null) return;

            Delegates -= d;
        }

        public void NotifySubs()
        {
            if (Delegates == null) return;

            Delegates(this);
        }

        private SubscribersList SubscribersList = SubscribersList.Instance;
        private Del? Delegates;  // Объявление списка делегатов
    }
}
