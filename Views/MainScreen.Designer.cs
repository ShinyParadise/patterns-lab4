namespace Lab4_Library
{
    partial class MainScreen
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            AddSubBtn = new Button();
            SubName = new TextBox();
            SubListLabel = new Label();
            SubList = new ListBox();
            RemoveSubBtn = new Button();
            Logo = new PictureBox();
            OwnedBooksList = new ListBox();
            AllBooksList = new ListBox();
            BookListLabel = new Label();
            OwnedBooksLabel = new Label();
            IssueBookBtn = new Button();
            ReturnBookBtn = new Button();
            NotifyBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // AddSubBtn
            // 
            AddSubBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddSubBtn.Location = new Point(27, 101);
            AddSubBtn.Name = "AddSubBtn";
            AddSubBtn.Size = new Size(239, 43);
            AddSubBtn.TabIndex = 0;
            AddSubBtn.Text = "Стать читателем";
            AddSubBtn.UseVisualStyleBackColor = true;
            AddSubBtn.Click += AddSubBtn_Click;
            // 
            // SubName
            // 
            SubName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubName.Location = new Point(27, 41);
            SubName.Name = "SubName";
            SubName.PlaceholderText = "Введите ваше имя";
            SubName.Size = new Size(239, 34);
            SubName.TabIndex = 1;
            // 
            // SubListLabel
            // 
            SubListLabel.AutoSize = true;
            SubListLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubListLabel.Location = new Point(45, 176);
            SubListLabel.Name = "SubListLabel";
            SubListLabel.Size = new Size(189, 28);
            SubListLabel.TabIndex = 2;
            SubListLabel.Text = "Список читателей";
            // 
            // SubList
            // 
            SubList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SubList.FormattingEnabled = true;
            SubList.ItemHeight = 23;
            SubList.Location = new Point(27, 224);
            SubList.Name = "SubList";
            SubList.Size = new Size(239, 349);
            SubList.TabIndex = 3;
            // 
            // RemoveSubBtn
            // 
            RemoveSubBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveSubBtn.Location = new Point(27, 606);
            RemoveSubBtn.Name = "RemoveSubBtn";
            RemoveSubBtn.Size = new Size(239, 43);
            RemoveSubBtn.TabIndex = 4;
            RemoveSubBtn.Text = "Удалить читателя";
            RemoveSubBtn.UseVisualStyleBackColor = true;
            RemoveSubBtn.Click += RemoveSubBtn_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImage = Lab4.Properties.Resources.Logo;
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(1241, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(181, 171);
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // OwnedBooksList
            // 
            OwnedBooksList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OwnedBooksList.FormattingEnabled = true;
            OwnedBooksList.ItemHeight = 23;
            OwnedBooksList.Location = new Point(388, 224);
            OwnedBooksList.Name = "OwnedBooksList";
            OwnedBooksList.Size = new Size(239, 349);
            OwnedBooksList.TabIndex = 6;
            // 
            // AllBooksList
            // 
            AllBooksList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AllBooksList.FormattingEnabled = true;
            AllBooksList.ItemHeight = 23;
            AllBooksList.Location = new Point(752, 224);
            AllBooksList.Name = "AllBooksList";
            AllBooksList.Size = new Size(670, 349);
            AllBooksList.TabIndex = 7;
            // 
            // BookListLabel
            // 
            BookListLabel.AutoSize = true;
            BookListLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BookListLabel.Location = new Point(765, 176);
            BookListLabel.Name = "BookListLabel";
            BookListLabel.Size = new Size(211, 28);
            BookListLabel.TabIndex = 8;
            BookListLabel.Text = "Книги в библиотеке";
            // 
            // OwnedBooksLabel
            // 
            OwnedBooksLabel.AutoSize = true;
            OwnedBooksLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OwnedBooksLabel.Location = new Point(408, 176);
            OwnedBooksLabel.Name = "OwnedBooksLabel";
            OwnedBooksLabel.Size = new Size(182, 28);
            OwnedBooksLabel.TabIndex = 9;
            OwnedBooksLabel.Text = "Книги у читателя";
            // 
            // IssueBookBtn
            // 
            IssueBookBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IssueBookBtn.Location = new Point(752, 606);
            IssueBookBtn.Name = "IssueBookBtn";
            IssueBookBtn.Size = new Size(670, 43);
            IssueBookBtn.TabIndex = 11;
            IssueBookBtn.Text = "Взять книгу";
            IssueBookBtn.UseVisualStyleBackColor = true;
            IssueBookBtn.Click += IssueBookBtn_Click;
            // 
            // ReturnBookBtn
            // 
            ReturnBookBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnBookBtn.Location = new Point(388, 606);
            ReturnBookBtn.Name = "ReturnBookBtn";
            ReturnBookBtn.Size = new Size(239, 43);
            ReturnBookBtn.TabIndex = 12;
            ReturnBookBtn.Text = "Вернуть книгу";
            ReturnBookBtn.UseVisualStyleBackColor = true;
            ReturnBookBtn.Click += ReturnBookBtn_Click;
            // 
            // NotifyBtn
            // 
            NotifyBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NotifyBtn.Location = new Point(388, 41);
            NotifyBtn.Name = "NotifyBtn";
            NotifyBtn.Size = new Size(805, 103);
            NotifyBtn.TabIndex = 13;
            NotifyBtn.Text = "Оповестить читаталей о сроках сдачи";
            NotifyBtn.UseVisualStyleBackColor = true;
            NotifyBtn.Click += Notify_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 672);
            Controls.Add(NotifyBtn);
            Controls.Add(ReturnBookBtn);
            Controls.Add(IssueBookBtn);
            Controls.Add(OwnedBooksLabel);
            Controls.Add(BookListLabel);
            Controls.Add(AllBooksList);
            Controls.Add(OwnedBooksList);
            Controls.Add(Logo);
            Controls.Add(RemoveSubBtn);
            Controls.Add(SubList);
            Controls.Add(SubListLabel);
            Controls.Add(SubName);
            Controls.Add(AddSubBtn);
            Name = "MainScreen";
            Text = "Library";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddSubBtn;
        private TextBox SubName;
        private Label SubListLabel;
        private ListBox SubList;
        private Button RemoveSubBtn;
        private PictureBox Logo;
        private ListBox OwnedBooksList;
        private ListBox AllBooksList;
        private Label BookListLabel;
        private Label OwnedBooksLabel;
        private Button IssueBookBtn;
        private Button ReturnBookBtn;
        private Button NotifyBtn;
    }
}