namespace Lab4.Models
{
    public class Librarian : IObserver
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

        public void Update(object o)
        {
            int userId = int.Parse(o.ToString());
            var sub = SubscribersList[userId];
            sub.Fine(500);
        }

        private SubscribersList SubscribersList = SubscribersList.Instance;
    }
}
