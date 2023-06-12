namespace Lab4.Models
{
    public abstract class LibraryDepartment
    {
        protected List<Book> Books { get; set; } = new List<Book>();

        public Book? TakeABook(string title)
        {
            Book? bookToTake = null;

            foreach (Book book in Books)
            {
                if (book.Title == title)
                {
                    bookToTake = book;
                    Books.Remove(book);
                    break;
                }
            }
            return bookToTake;
        }
        public void PutABook(Book book) { Books.Add(book); }

        public int GetAllBookCount () { return Books.Count; }
        public int GetBookCount(string title)
        {
            int count = 0;
            foreach (Book book in Books) if (book.Title == title) count++;
            
            return count;
        }
    }

    public class TechDepartment : LibraryDepartment
    {
        private TechDepartment() {}
        private static TechDepartment? _instance;
        public static TechDepartment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TechDepartment();

                return _instance;
            }
        }
    }

    public class FictionDepartment : LibraryDepartment
    {
        private FictionDepartment() {}


        private static FictionDepartment? _instance;
        public static FictionDepartment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FictionDepartment();

                return _instance;
            }
        }
    }
}
