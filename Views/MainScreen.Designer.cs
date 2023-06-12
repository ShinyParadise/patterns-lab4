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
            SubListBox = new ListBox();
            RemoveSubBtn = new Button();
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
            // SubListBox
            // 
            SubListBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SubListBox.FormattingEnabled = true;
            SubListBox.ItemHeight = 23;
            SubListBox.Location = new Point(27, 224);
            SubListBox.Name = "SubListBox";
            SubListBox.Size = new Size(239, 349);
            SubListBox.TabIndex = 3;
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
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 673);
            Controls.Add(RemoveSubBtn);
            Controls.Add(SubListBox);
            Controls.Add(SubListLabel);
            Controls.Add(SubName);
            Controls.Add(AddSubBtn);
            Name = "MainScreen";
            Text = "Library";
            Load += MainScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddSubBtn;
        private TextBox SubName;
        private Label SubListLabel;
        private ListBox SubListBox;
        private Button RemoveSubBtn;
    }
}