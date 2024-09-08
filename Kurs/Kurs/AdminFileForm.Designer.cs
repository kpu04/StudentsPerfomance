
namespace Kurs
{
    partial class AdminFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFileForm));
            FileCreating = new System.Windows.Forms.Button();
            NameOfFileBox = new System.Windows.Forms.TextBox();
            CreatNewFileButton = new System.Windows.Forms.Button();
            CreateFileLabel = new System.Windows.Forms.Label();
            FileDeleting = new System.Windows.Forms.Button();
            FileDeleteButton = new System.Windows.Forms.Button();
            OpenFileButton = new System.Windows.Forms.Button();
            OpenButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // FileCreating
            // 
            FileCreating.Location = new System.Drawing.Point(60, 184);
            FileCreating.Margin = new System.Windows.Forms.Padding(5);
            FileCreating.Name = "FileCreating";
            FileCreating.Size = new System.Drawing.Size(297, 46);
            FileCreating.TabIndex = 0;
            FileCreating.Text = "Создать новый файл";
            FileCreating.UseVisualStyleBackColor = true;
            FileCreating.Click += FileCreating_Click;
            // 
            // NameOfFileBox
            // 
            NameOfFileBox.Location = new System.Drawing.Point(62, 66);
            NameOfFileBox.Margin = new System.Windows.Forms.Padding(5);
            NameOfFileBox.Name = "NameOfFileBox";
            NameOfFileBox.Size = new System.Drawing.Size(295, 39);
            NameOfFileBox.TabIndex = 1;
            NameOfFileBox.Visible = false;
            // 
            // CreatNewFileButton
            // 
            CreatNewFileButton.Location = new System.Drawing.Point(62, 118);
            CreatNewFileButton.Margin = new System.Windows.Forms.Padding(5);
            CreatNewFileButton.Name = "CreatNewFileButton";
            CreatNewFileButton.Size = new System.Drawing.Size(297, 46);
            CreatNewFileButton.TabIndex = 2;
            CreatNewFileButton.Text = "Создать";
            CreatNewFileButton.UseVisualStyleBackColor = true;
            CreatNewFileButton.Visible = false;
            CreatNewFileButton.Click += CreatNewFileButton_Click;
            // 
            // CreateFileLabel
            // 
            CreateFileLabel.AutoSize = true;
            CreateFileLabel.Location = new System.Drawing.Point(20, 29);
            CreateFileLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            CreateFileLabel.Name = "CreateFileLabel";
            CreateFileLabel.Size = new System.Drawing.Size(394, 32);
            CreateFileLabel.TabIndex = 3;
            CreateFileLabel.Text = "Введите имя и расширение файла";
            CreateFileLabel.Visible = false;
            // 
            // FileDeleting
            // 
            FileDeleting.Location = new System.Drawing.Point(60, 250);
            FileDeleting.Margin = new System.Windows.Forms.Padding(5);
            FileDeleting.Name = "FileDeleting";
            FileDeleting.Size = new System.Drawing.Size(297, 46);
            FileDeleting.TabIndex = 4;
            FileDeleting.Text = "Удалить файл";
            FileDeleting.UseVisualStyleBackColor = true;
            FileDeleting.Click += FileDeleting_Click;
            // 
            // FileDeleteButton
            // 
            FileDeleteButton.Location = new System.Drawing.Point(62, 118);
            FileDeleteButton.Margin = new System.Windows.Forms.Padding(5);
            FileDeleteButton.Name = "FileDeleteButton";
            FileDeleteButton.Size = new System.Drawing.Size(297, 46);
            FileDeleteButton.TabIndex = 5;
            FileDeleteButton.Text = "Удалить";
            FileDeleteButton.UseVisualStyleBackColor = true;
            FileDeleteButton.Visible = false;
            FileDeleteButton.Click += FileDeleteButton_Click;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new System.Drawing.Point(60, 320);
            OpenFileButton.Margin = new System.Windows.Forms.Padding(5);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new System.Drawing.Size(297, 46);
            OpenFileButton.TabIndex = 7;
            OpenFileButton.Text = "Открыть файл";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Location = new System.Drawing.Point(62, 118);
            OpenButton.Margin = new System.Windows.Forms.Padding(5);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new System.Drawing.Size(297, 46);
            OpenButton.TabIndex = 8;
            OpenButton.Text = "Открыть";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Visible = false;
            OpenButton.Click += OpenButton_Click;
            // 
            // AdminFileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(436, 394);
            Controls.Add(OpenButton);
            Controls.Add(OpenFileButton);
            Controls.Add(FileDeleteButton);
            Controls.Add(FileDeleting);
            Controls.Add(CreateFileLabel);
            Controls.Add(CreatNewFileButton);
            Controls.Add(NameOfFileBox);
            Controls.Add(FileCreating);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "AdminFileForm";
            Text = "Модуль администратора: работа с файлами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button FileCreating;
        private System.Windows.Forms.TextBox NameOfFileBox;
        private System.Windows.Forms.Button CreatNewFileButton;
        private System.Windows.Forms.Label CreateFileLabel;
        private System.Windows.Forms.Button FileDeleting;
        private System.Windows.Forms.Button FileDeleteButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button OpenButton;
    }
}