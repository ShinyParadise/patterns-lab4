using Lab4.Models;
using Lab4.ViewModels;

namespace Lab4_Library
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            viewModel.AddSampleData();
            UpdateAllLists();

            SubList.SelectedIndexChanged += SubList_SelectedIndexChanged;
            AllBooksList.SelectedIndexChanged += AllBooksList_SelectedIndexChanged;
            OwnedBooksList.SelectedIndexChanged += OwnedBooksList_SelectedIndexChanged;
        }

        private void UpdateAllLists()
        {
            UpdateSubList();
            UpdateOwnedBooksList();
            UpdateAllBooksList();
        }

        private void UpdateAllBooksList()
        {
            var books = viewModel.GetAllBooks;
            var bookNames = books.Select(s => s.Title).ToArray();
            AllBooksList.Items.Clear();
            AllBooksList.Items.AddRange(bookNames);
        }

        private void UpdateSubList()
        {
            List<Subscriber> subs = viewModel.GetSubs;
            string[] subNames = subs.Select(s => $"{s.Name} : {s.Id}").ToArray();
            SubList.Items.Clear();
            SubList.Items.AddRange(subNames);
        }

        private void UpdateOwnedBooksList()
        {
            List<Subscriber> subs = viewModel.GetSubs;
            var subIndex = SubList.SelectedIndex;
            if (subIndex == -1)
            {
                OwnedBooksList.Items.Clear();
                return;
            }

            Subscriber sub = subs[subIndex];
            string[] books = sub.OwnedBooks.Select(s => $"{s.Title}").ToArray();

            OwnedBooksList.Items.Clear();
            OwnedBooksList.Items.AddRange(books);
        }



        private void AddSubBtn_Click(object sender, EventArgs e)
        {
            string enteredName = SubName.Text;
            if (enteredName == null || enteredName.Length == 0)
            {
                MessageBox.Show("ѕожалуйста, введите свое им€");
                return;
            }

            viewModel.RegisterNewSub(enteredName);
            UpdateSubList();
        }

        private void RemoveSubBtn_Click(object sender, EventArgs e)
        {
            var subIndex = viewModel.selectedSub;
            if (subIndex == -1)
            {
                MessageBox.Show("„тобы удалить читател€, выберите его из списка");
                return;
            }

            var sub = viewModel.GetSubs[subIndex];
            viewModel.RemoveSub(sub.Id);
            UpdateSubList();
            UpdateOwnedBooksList();
        }

        private void IssueBookBtn_Click(object sender, EventArgs e)
        {
            var subIndex = viewModel.selectedSub;
            var bookIndex = viewModel.bookToTake;
            if (subIndex == -1 || bookIndex == -1)
            {
                MessageBox.Show("„тобы вз€ть книгу, выберите свою карточку в меню слева, а книгу справа");
                return;
            }
            var sub = viewModel.GetSubs[subIndex];
            var book = viewModel.GetAllBooks[bookIndex];

            viewModel.IssueBook(book.Id, sub.Id);
            UpdateAllLists();
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            var subIndex = viewModel.selectedSub;
            var bookIndex = viewModel.bookToReturn;
            if (subIndex == -1 || bookIndex == -1)
            {
                MessageBox.Show("„тобы вернуть книгу, выберите свою карточку в меню слева и книгу в меню посередине");
                return;
            }
            var sub = viewModel.GetSubs[subIndex];
            Book book = sub.OwnedBooks[bookIndex];

            viewModel.ReturnBook(book);
            UpdateAllLists();
        }

        private void SubList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateOwnedBooksList();
            viewModel.selectedSub = SubList.SelectedIndex;
        }

        private void AllBooksList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            viewModel.bookToTake = AllBooksList.SelectedIndex;
        }

        private void OwnedBooksList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            viewModel.bookToReturn = OwnedBooksList.SelectedIndex;
        }

        private MainViewModel viewModel = new();
    }
}