namespace Lab4.Models
{
    public class Book
    {
        public Book(
            string title, string author, BookCard card, string location, Genre genre)
        {
            Title = title;
            Genre = genre;
            Author = author;
            Card = card;
            Location = location;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public BookCard Card { get; private set; }
        public string Location { get; set; }
        public Genre Genre { get; private set; }
    }
    
    public class BookCard
    {
        public BookCard(Subscriber sub, DateTime dueDate, DateTime issueDate)
        {
            Sub = sub;
            DueDate = dueDate;
            IssueDate = issueDate;
        }

        public void WriteIssueNotes(Subscriber subscriber, DateTime issueDate, DateTime dueDate)
        {
            Sub = subscriber;
            DueDate = dueDate;
            IssueDate = issueDate;
        }

        public void ReturnBook()
        {
            Sub = null;
        }

        public Subscriber? Sub { get; set; }
        public DateTime DueDate { get; private set; }
        public DateTime IssueDate { get; private set; }
    }

    public enum Genre
    {
        Tech, Fiction
    }
}
