
namespace Kurs
{
    partial class AdminMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            MenuLabel = new System.Windows.Forms.Label();
            AccountsButton = new System.Windows.Forms.Button();
            CanselButton = new System.Windows.Forms.Button();
            ListOfAccounts = new System.Windows.Forms.ListBox();
            EnterLoginLabel = new System.Windows.Forms.Label();
            AddUserButton = new System.Windows.Forms.Button();
            EnterLoginBox = new System.Windows.Forms.TextBox();
            EnterPasswordLabel = new System.Windows.Forms.Label();
            EnterPasswordBox = new System.Windows.Forms.TextBox();
            EnterRoleBox = new System.Windows.Forms.TextBox();
            EnterRoleLabel = new System.Windows.Forms.Label();
            AddNewUserButton = new System.Windows.Forms.Button();
            DeleteAccountButton = new System.Windows.Forms.Button();
            ModerateAccountButton = new System.Windows.Forms.Button();
            EndChanges = new System.Windows.Forms.Button();
            WorkWithFilesButton = new System.Windows.Forms.Button();
            ScholarshipCalculationButton = new System.Windows.Forms.Button();
            BasicSizeBox = new System.Windows.Forms.TextBox();
            BasicSize = new System.Windows.Forms.Label();
            Sort1 = new System.Windows.Forms.Button();
            Sort2 = new System.Windows.Forms.Button();
            GroupSort = new System.Windows.Forms.Button();
            Students = new System.Windows.Forms.Button();
            Search = new System.Windows.Forms.Button();
            SearchBox = new System.Windows.Forms.TextBox();
            Reset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.BackColor = System.Drawing.Color.Transparent;
            MenuLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            MenuLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            MenuLabel.Location = new System.Drawing.Point(633, 22);
            MenuLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new System.Drawing.Size(117, 45);
            MenuLabel.TabIndex = 0;
            MenuLabel.Text = "Меню";
            // 
            // AccountsButton
            // 
            AccountsButton.Location = new System.Drawing.Point(549, 128);
            AccountsButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Size = new System.Drawing.Size(268, 46);
            AccountsButton.TabIndex = 1;
            AccountsButton.Text = "Учетные записи";
            AccountsButton.UseVisualStyleBackColor = true;
            AccountsButton.Click += AccountsButton_Click;
            // 
            // CanselButton
            // 
            CanselButton.Location = new System.Drawing.Point(21, 643);
            CanselButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            CanselButton.Name = "CanselButton";
            CanselButton.Size = new System.Drawing.Size(153, 46);
            CanselButton.TabIndex = 2;
            CanselButton.Text = "Назад";
            CanselButton.UseVisualStyleBackColor = true;
            CanselButton.Visible = false;
            CanselButton.Click += CanselButton_Click;
            // 
            // ListOfAccounts
            // 
            ListOfAccounts.FormattingEnabled = true;
            ListOfAccounts.HorizontalScrollbar = true;
            ListOfAccounts.ItemHeight = 32;
            ListOfAccounts.Location = new System.Drawing.Point(21, 21);
            ListOfAccounts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ListOfAccounts.Name = "ListOfAccounts";
            ListOfAccounts.ScrollAlwaysVisible = true;
            ListOfAccounts.Size = new System.Drawing.Size(516, 580);
            ListOfAccounts.TabIndex = 3;
            ListOfAccounts.Visible = false;
            // 
            // EnterLoginLabel
            // 
            EnterLoginLabel.AutoSize = true;
            EnterLoginLabel.Location = new System.Drawing.Point(980, 21);
            EnterLoginLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EnterLoginLabel.Name = "EnterLoginLabel";
            EnterLoginLabel.Size = new System.Drawing.Size(175, 32);
            EnterLoginLabel.TabIndex = 4;
            EnterLoginLabel.Text = "Введите логин";
            EnterLoginLabel.Visible = false;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new System.Drawing.Point(218, 643);
            AddUserButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new System.Drawing.Size(247, 46);
            AddUserButton.TabIndex = 5;
            AddUserButton.Text = "Добавить аккаунт";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Visible = false;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // EnterLoginBox
            // 
            EnterLoginBox.Location = new System.Drawing.Point(920, 74);
            EnterLoginBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterLoginBox.Name = "EnterLoginBox";
            EnterLoginBox.Size = new System.Drawing.Size(298, 39);
            EnterLoginBox.TabIndex = 6;
            EnterLoginBox.Visible = false;
            // 
            // EnterPasswordLabel
            // 
            EnterPasswordLabel.AutoSize = true;
            EnterPasswordLabel.Location = new System.Drawing.Point(980, 142);
            EnterPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EnterPasswordLabel.Name = "EnterPasswordLabel";
            EnterPasswordLabel.Size = new System.Drawing.Size(190, 32);
            EnterPasswordLabel.TabIndex = 7;
            EnterPasswordLabel.Text = "Введите пароль";
            EnterPasswordLabel.Visible = false;
            // 
            // EnterPasswordBox
            // 
            EnterPasswordBox.Location = new System.Drawing.Point(920, 195);
            EnterPasswordBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterPasswordBox.Name = "EnterPasswordBox";
            EnterPasswordBox.Size = new System.Drawing.Size(298, 39);
            EnterPasswordBox.TabIndex = 8;
            EnterPasswordBox.Visible = false;
            // 
            // EnterRoleBox
            // 
            EnterRoleBox.Location = new System.Drawing.Point(980, 344);
            EnterRoleBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterRoleBox.Name = "EnterRoleBox";
            EnterRoleBox.Size = new System.Drawing.Size(176, 39);
            EnterRoleBox.TabIndex = 9;
            EnterRoleBox.Visible = false;
            // 
            // EnterRoleLabel
            // 
            EnterRoleLabel.AutoSize = true;
            EnterRoleLabel.Location = new System.Drawing.Point(835, 307);
            EnterRoleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EnterRoleLabel.Name = "EnterRoleLabel";
            EnterRoleLabel.Size = new System.Drawing.Size(495, 32);
            EnterRoleLabel.TabIndex = 10;
            EnterRoleLabel.Text = "Укажите роль (1 - админ, 0 - пользователь)";
            EnterRoleLabel.Visible = false;
            // 
            // AddNewUserButton
            // 
            AddNewUserButton.Location = new System.Drawing.Point(949, 416);
            AddNewUserButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            AddNewUserButton.Name = "AddNewUserButton";
            AddNewUserButton.Size = new System.Drawing.Size(244, 46);
            AddNewUserButton.TabIndex = 11;
            AddNewUserButton.Text = "Добавить аккаунт";
            AddNewUserButton.UseVisualStyleBackColor = true;
            AddNewUserButton.Visible = false;
            AddNewUserButton.Click += AddNewUserButton_Click;
            // 
            // DeleteAccountButton
            // 
            DeleteAccountButton.Location = new System.Drawing.Point(769, 643);
            DeleteAccountButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            DeleteAccountButton.Name = "DeleteAccountButton";
            DeleteAccountButton.Size = new System.Drawing.Size(221, 46);
            DeleteAccountButton.TabIndex = 12;
            DeleteAccountButton.Text = "Удалить аккаунт";
            DeleteAccountButton.UseVisualStyleBackColor = true;
            DeleteAccountButton.Visible = false;
            DeleteAccountButton.Click += DeleteAccountButton_Click;
            // 
            // ModerateAccountButton
            // 
            ModerateAccountButton.Location = new System.Drawing.Point(474, 643);
            ModerateAccountButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ModerateAccountButton.Name = "ModerateAccountButton";
            ModerateAccountButton.Size = new System.Drawing.Size(284, 46);
            ModerateAccountButton.TabIndex = 13;
            ModerateAccountButton.Text = "Редактировать аккаунт";
            ModerateAccountButton.UseVisualStyleBackColor = true;
            ModerateAccountButton.Visible = false;
            ModerateAccountButton.Click += ModerateAccountButton_Click;
            // 
            // EndChanges
            // 
            EndChanges.Location = new System.Drawing.Point(926, 472);
            EndChanges.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EndChanges.Name = "EndChanges";
            EndChanges.Size = new System.Drawing.Size(296, 46);
            EndChanges.TabIndex = 14;
            EndChanges.Text = "Завершить изменения";
            EndChanges.UseVisualStyleBackColor = true;
            EndChanges.Visible = false;
            EndChanges.Click += EndChanges_Click;
            // 
            // WorkWithFilesButton
            // 
            WorkWithFilesButton.Location = new System.Drawing.Point(549, 195);
            WorkWithFilesButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            WorkWithFilesButton.Name = "WorkWithFilesButton";
            WorkWithFilesButton.Size = new System.Drawing.Size(268, 46);
            WorkWithFilesButton.TabIndex = 15;
            WorkWithFilesButton.Text = "Файлы";
            WorkWithFilesButton.UseVisualStyleBackColor = true;
            WorkWithFilesButton.Click += WorkWithFilesButton_Click;
            // 
            // ScholarshipCalculationButton
            // 
            ScholarshipCalculationButton.Location = new System.Drawing.Point(549, 366);
            ScholarshipCalculationButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ScholarshipCalculationButton.Name = "ScholarshipCalculationButton";
            ScholarshipCalculationButton.Size = new System.Drawing.Size(268, 46);
            ScholarshipCalculationButton.TabIndex = 16;
            ScholarshipCalculationButton.Text = "Расчет";
            ScholarshipCalculationButton.UseVisualStyleBackColor = true;
            ScholarshipCalculationButton.Click += ScholarshipCalculationButton_Click;
            // 
            // BasicSizeBox
            // 
            BasicSizeBox.Location = new System.Drawing.Point(549, 314);
            BasicSizeBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            BasicSizeBox.Name = "BasicSizeBox";
            BasicSizeBox.Size = new System.Drawing.Size(266, 39);
            BasicSizeBox.TabIndex = 17;
            BasicSizeBox.Text = "90";
            // 
            // BasicSize
            // 
            BasicSize.AutoSize = true;
            BasicSize.Location = new System.Drawing.Point(549, 277);
            BasicSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BasicSize.Name = "BasicSize";
            BasicSize.Size = new System.Drawing.Size(265, 32);
            BasicSize.TabIndex = 18;
            BasicSize.Text = "Базовая стипендия(Br):";
            // 
            // Sort1
            // 
            Sort1.Location = new System.Drawing.Point(549, 424);
            Sort1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Sort1.Name = "Sort1";
            Sort1.Size = new System.Drawing.Size(367, 46);
            Sort1.TabIndex = 19;
            Sort1.Text = "Сортировка по ФИО от А до Я";
            Sort1.UseVisualStyleBackColor = true;
            Sort1.Visible = false;
            Sort1.Click += Sort1_Click;
            // 
            // Sort2
            // 
            Sort2.Location = new System.Drawing.Point(549, 482);
            Sort2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Sort2.Name = "Sort2";
            Sort2.Size = new System.Drawing.Size(367, 46);
            Sort2.TabIndex = 20;
            Sort2.Text = "Сортировка по ФИО от Я до А";
            Sort2.UseVisualStyleBackColor = true;
            Sort2.Visible = false;
            Sort2.Click += Sort2_Click;
            // 
            // GroupSort
            // 
            GroupSort.Location = new System.Drawing.Point(549, 539);
            GroupSort.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            GroupSort.Name = "GroupSort";
            GroupSort.Size = new System.Drawing.Size(367, 46);
            GroupSort.TabIndex = 21;
            GroupSort.Text = "Сортировка по группе";
            GroupSort.UseVisualStyleBackColor = true;
            GroupSort.Visible = false;
            GroupSort.Click += GroupSort_Click;
            // 
            // Students
            // 
            Students.Location = new System.Drawing.Point(549, 72);
            Students.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Students.Name = "Students";
            Students.Size = new System.Drawing.Size(268, 46);
            Students.TabIndex = 22;
            Students.Text = "Студенты";
            Students.UseVisualStyleBackColor = true;
            Students.Click += Students_Click;
            // 
            // Search
            // 
            Search.Location = new System.Drawing.Point(1006, 381);
            Search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(153, 46);
            Search.TabIndex = 23;
            Search.Text = "Поиск";
            Search.UseVisualStyleBackColor = true;
            Search.Visible = false;
            Search.Click += Search_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new System.Drawing.Point(921, 328);
            SearchBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new System.Drawing.Size(298, 39);
            SearchBox.TabIndex = 24;
            SearchBox.Visible = false;
            // 
            // Reset
            // 
            Reset.Location = new System.Drawing.Point(1006, 438);
            Reset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(153, 46);
            Reset.TabIndex = 25;
            Reset.Text = "Сбросить";
            Reset.UseVisualStyleBackColor = true;
            Reset.Visible = false;
            Reset.Click += Reset_Click;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1381, 720);
            Controls.Add(Reset);
            Controls.Add(SearchBox);
            Controls.Add(Search);
            Controls.Add(Students);
            Controls.Add(GroupSort);
            Controls.Add(Sort2);
            Controls.Add(Sort1);
            Controls.Add(ListOfAccounts);
            Controls.Add(BasicSize);
            Controls.Add(BasicSizeBox);
            Controls.Add(ScholarshipCalculationButton);
            Controls.Add(WorkWithFilesButton);
            Controls.Add(EndChanges);
            Controls.Add(ModerateAccountButton);
            Controls.Add(DeleteAccountButton);
            Controls.Add(AddNewUserButton);
            Controls.Add(EnterRoleLabel);
            Controls.Add(EnterRoleBox);
            Controls.Add(EnterPasswordBox);
            Controls.Add(EnterPasswordLabel);
            Controls.Add(EnterLoginBox);
            Controls.Add(AddUserButton);
            Controls.Add(EnterLoginLabel);
            Controls.Add(CanselButton);
            Controls.Add(AccountsButton);
            Controls.Add(MenuLabel);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "AdminMenuForm";
            Text = "Модуль администратора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button AccountsButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.ListBox ListOfAccounts;
        private System.Windows.Forms.Label EnterLoginLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox EnterLoginBox;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.TextBox EnterPasswordBox;
        private System.Windows.Forms.TextBox EnterRoleBox;
        private System.Windows.Forms.Label EnterRoleLabel;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button ModerateAccountButton;
        private System.Windows.Forms.Button EndChanges;
        private System.Windows.Forms.Button WorkWithFilesButton;
        private System.Windows.Forms.Button ScholarshipCalculationButton;
        private System.Windows.Forms.TextBox BasicSizeBox;
        private System.Windows.Forms.Label BasicSize;
        private System.Windows.Forms.Button Sort1;
        private System.Windows.Forms.Button Sort2;
        private System.Windows.Forms.Button GroupSort;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Reset;
    }
}