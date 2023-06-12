namespace Lab4.Models
{
    public abstract class LibraryDepartment
    {
        public List<Book> Books { get; private set; } = new List<Book>();

        public Book? TakeABook(int bookId)
        {
            var book = Books.FirstOrDefault(x => x.Id == bookId);
            if (book != null) Books.Remove(book);
            return book;
        }
        public void PutABook(params Book[] book) { Books.AddRange(book); }
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
