
namespace Kurs
{
    partial class UserForm
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
            ScreenListBox = new System.Windows.Forms.ListBox();
            BasicSizeBox = new System.Windows.Forms.TextBox();
            ScholarshipCalculationButton = new System.Windows.Forms.Button();
            NameOfFileBox = new System.Windows.Forms.TextBox();
            OpenButton = new System.Windows.Forms.Button();
            BasicSize = new System.Windows.Forms.Label();
            CreateFileLabel = new System.Windows.Forms.Label();
            Sort1 = new System.Windows.Forms.Button();
            Sort2 = new System.Windows.Forms.Button();
            GroupSort = new System.Windows.Forms.Button();
            Students = new System.Windows.Forms.Button();
            SearchBox = new System.Windows.Forms.TextBox();
            Search = new System.Windows.Forms.Button();
            Reset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ScreenListBox
            // 
            ScreenListBox.FormattingEnabled = true;
            ScreenListBox.HorizontalScrollbar = true;
            ScreenListBox.ItemHeight = 32;
            ScreenListBox.Location = new System.Drawing.Point(434, 19);
            ScreenListBox.Margin = new System.Windows.Forms.Padding(5);
            ScreenListBox.Name = "ScreenListBox";
            ScreenListBox.Size = new System.Drawing.Size(781, 804);
            ScreenListBox.TabIndex = 0;
            // 
            // BasicSizeBox
            // 
            BasicSizeBox.Location = new System.Drawing.Point(78, 286);
            BasicSizeBox.Margin = new System.Windows.Forms.Padding(5);
            BasicSizeBox.Name = "BasicSizeBox";
            BasicSizeBox.Size = new System.Drawing.Size(244, 39);
            BasicSizeBox.TabIndex = 1;
            BasicSizeBox.Text = "90";
            // 
            // ScholarshipCalculationButton
            // 
            ScholarshipCalculationButton.Location = new System.Drawing.Point(78, 339);
            ScholarshipCalculationButton.Margin = new System.Windows.Forms.Padding(5);
            ScholarshipCalculationButton.Name = "ScholarshipCalculationButton";
            ScholarshipCalculationButton.Size = new System.Drawing.Size(245, 46);
            ScholarshipCalculationButton.TabIndex = 2;
            ScholarshipCalculationButton.Text = "Расчет";
            ScholarshipCalculationButton.UseVisualStyleBackColor = true;
            ScholarshipCalculationButton.Click += ScholarshipCalculationButton_Click;
            // 
            // NameOfFileBox
            // 
            NameOfFileBox.Location = new System.Drawing.Point(78, 75);
            NameOfFileBox.Margin = new System.Windows.Forms.Padding(5);
            NameOfFileBox.Name = "NameOfFileBox";
            NameOfFileBox.Size = new System.Drawing.Size(244, 39);
            NameOfFileBox.TabIndex = 3;
            // 
            // OpenButton
            // 
            OpenButton.Location = new System.Drawing.Point(78, 128);
            OpenButton.Margin = new System.Windows.Forms.Padding(5);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new System.Drawing.Size(247, 46);
            OpenButton.TabIndex = 4;
            OpenButton.Text = "Открыть файл";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // BasicSize
            // 
            BasicSize.AutoSize = true;
            BasicSize.Location = new System.Drawing.Point(63, 250);
            BasicSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BasicSize.Name = "BasicSize";
            BasicSize.Size = new System.Drawing.Size(265, 32);
            BasicSize.TabIndex = 5;
            BasicSize.Text = "Базовая стипендия(Br):";
            // 
            // CreateFileLabel
            // 
            CreateFileLabel.AutoSize = true;
            CreateFileLabel.Location = new System.Drawing.Point(20, 19);
            CreateFileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            CreateFileLabel.Name = "CreateFileLabel";
            CreateFileLabel.Size = new System.Drawing.Size(394, 32);
            CreateFileLabel.TabIndex = 6;
            CreateFileLabel.Text = "Введите имя и расширение файла";
            // 
            // Sort1
            // 
            Sort1.Location = new System.Drawing.Point(20, 395);
            Sort1.Margin = new System.Windows.Forms.Padding(5);
            Sort1.Name = "Sort1";
            Sort1.Size = new System.Drawing.Size(390, 46);
            Sort1.TabIndex = 7;
            Sort1.Text = "Сортировка по ФИО от А до Я";
            Sort1.UseVisualStyleBackColor = true;
            Sort1.Visible = false;
            Sort1.Click += Sort1_Click;
            // 
            // Sort2
            // 
            Sort2.Location = new System.Drawing.Point(20, 453);
            Sort2.Margin = new System.Windows.Forms.Padding(5);
            Sort2.Name = "Sort2";
            Sort2.Size = new System.Drawing.Size(390, 46);
            Sort2.TabIndex = 8;
            Sort2.Text = "Сортировка по ФИО от Я до А";
            Sort2.UseVisualStyleBackColor = true;
            Sort2.Visible = false;
            Sort2.Click += Sort2_Click;
            // 
            // GroupSort
            // 
            GroupSort.Location = new System.Drawing.Point(21, 510);
            GroupSort.Margin = new System.Windows.Forms.Padding(5);
            GroupSort.Name = "GroupSort";
            GroupSort.Size = new System.Drawing.Size(388, 46);
            GroupSort.TabIndex = 9;
            GroupSort.Text = "Сортировка по группе";
            GroupSort.UseVisualStyleBackColor = true;
            GroupSort.Visible = false;
            GroupSort.Click += GroupSort_Click;
            // 
            // Students
            // 
            Students.Location = new System.Drawing.Point(78, 186);
            Students.Margin = new System.Windows.Forms.Padding(5);
            Students.Name = "Students";
            Students.Size = new System.Drawing.Size(245, 46);
            Students.TabIndex = 10;
            Students.Text = "Список студентов";
            Students.UseVisualStyleBackColor = true;
            Students.Click += Students_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new System.Drawing.Point(78, 589);
            SearchBox.Margin = new System.Windows.Forms.Padding(5);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new System.Drawing.Size(243, 39);
            SearchBox.TabIndex = 11;
            SearchBox.Visible = false;
            // 
            // Search
            // 
            Search.Location = new System.Drawing.Point(78, 643);
            Search.Margin = new System.Windows.Forms.Padding(5);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(247, 46);
            Search.TabIndex = 12;
            Search.Text = "Поиск";
            Search.UseVisualStyleBackColor = true;
            Search.Visible = false;
            Search.Click += Search_Click;
            // 
            // Reset
            // 
            Reset.Location = new System.Drawing.Point(78, 701);
            Reset.Margin = new System.Windows.Forms.Padding(5);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(245, 46);
            Reset.TabIndex = 13;
            Reset.Text = "Сброс";
            Reset.UseVisualStyleBackColor = true;
            Reset.Visible = false;
            Reset.Click += Reset_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PeachPuff;
            ClientSize = new System.Drawing.Size(1245, 840);
            Controls.Add(Reset);
            Controls.Add(Search);
            Controls.Add(SearchBox);
            Controls.Add(Students);
            Controls.Add(GroupSort);
            Controls.Add(Sort2);
            Controls.Add(Sort1);
            Controls.Add(CreateFileLabel);
            Controls.Add(BasicSize);
            Controls.Add(OpenButton);
            Controls.Add(NameOfFileBox);
            Controls.Add(ScholarshipCalculationButton);
            Controls.Add(BasicSizeBox);
            Controls.Add(ScreenListBox);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "UserForm";
            Text = "Модуль пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ScreenListBox;
        private System.Windows.Forms.TextBox BasicSizeBox;
        private System.Windows.Forms.Button ScholarshipCalculationButton;
        private System.Windows.Forms.TextBox NameOfFileBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label BasicSize;
        private System.Windows.Forms.Label CreateFileLabel;
        private System.Windows.Forms.Button Sort1;
        private System.Windows.Forms.Button Sort2;
        private System.Windows.Forms.Button GroupSort;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Reset;
    }
}