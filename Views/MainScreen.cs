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
            UpdateSubList();
            SubListBox.SelectedIndexChanged += SubList_SelectedIndexChanged;
        }

        private void UpdateSubList()
        {
            List<Subscriber> subs = viewModel.GetSubs;
            string[] subNames = subs.Select(s => $"{s.Name} : {s.Id}").ToArray();
            SubListBox.Items.Clear();
            SubListBox.Items.AddRange(subNames);
        }

        private void AddSubBtn_Click(object sender, EventArgs e)
        {
            string enteredName = SubName.Text;
            if (enteredName == null || enteredName.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите свое имя");
                return;
            }

            viewModel.RegisterNewSub(enteredName);
            UpdateSubList();
        }

        private void RemoveSubBtn_Click(object sender, EventArgs e)
        {
            var subIndex = SubListBox.SelectedIndex;
            if (subIndex == -1)
            {
                MessageBox.Show("Чтобы удалить читателя, выберите его из списка");
                return;
            }

            var sub = viewModel.GetSubs[subIndex];
            viewModel.RemoveSub(sub.Id);
            UpdateSubList();
        }

        private void SubList_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private MainViewModel viewModel = new();
    }
}