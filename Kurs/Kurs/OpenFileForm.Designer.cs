
namespace Kurs
{
    partial class OpenFileForm
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
            ControlScreen = new System.Windows.Forms.TextBox();
            AddTextButton = new System.Windows.Forms.Button();
            DeleteTextButton = new System.Windows.Forms.Button();
            EndModeratingButton = new System.Windows.Forms.Button();
            Cansel = new System.Windows.Forms.Button();
            NameOfFile = new System.Windows.Forms.Label();
            ModeratingText = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ScreenListBox
            // 
            ScreenListBox.FormattingEnabled = true;
            ScreenListBox.HorizontalScrollbar = true;
            ScreenListBox.ItemHeight = 32;
            ScreenListBox.Location = new System.Drawing.Point(463, 19);
            ScreenListBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ScreenListBox.Name = "ScreenListBox";
            ScreenListBox.ScrollAlwaysVisible = true;
            ScreenListBox.Size = new System.Drawing.Size(815, 612);
            ScreenListBox.TabIndex = 7;
            // 
            // ControlScreen
            // 
            ControlScreen.Location = new System.Drawing.Point(49, 19);
            ControlScreen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ControlScreen.Multiline = true;
            ControlScreen.Name = "ControlScreen";
            ControlScreen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            ControlScreen.Size = new System.Drawing.Size(402, 358);
            ControlScreen.TabIndex = 11;
            // 
            // AddTextButton
            // 
            AddTextButton.Location = new System.Drawing.Point(101, 389);
            AddTextButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            AddTextButton.Name = "AddTextButton";
            AddTextButton.Size = new System.Drawing.Size(297, 46);
            AddTextButton.TabIndex = 12;
            AddTextButton.Text = "Добавить текст";
            AddTextButton.UseVisualStyleBackColor = true;
            AddTextButton.Click += AddTextButton_Click;
            // 
            // DeleteTextButton
            // 
            DeleteTextButton.Location = new System.Drawing.Point(101, 445);
            DeleteTextButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            DeleteTextButton.Name = "DeleteTextButton";
            DeleteTextButton.Size = new System.Drawing.Size(297, 46);
            DeleteTextButton.TabIndex = 13;
            DeleteTextButton.Text = "Удалить текст";
            DeleteTextButton.UseVisualStyleBackColor = true;
            DeleteTextButton.Click += DeleteTextButton_Click;
            // 
            // EndModeratingButton
            // 
            EndModeratingButton.Location = new System.Drawing.Point(101, 501);
            EndModeratingButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EndModeratingButton.Name = "EndModeratingButton";
            EndModeratingButton.Size = new System.Drawing.Size(297, 46);
            EndModeratingButton.TabIndex = 15;
            EndModeratingButton.Text = "Отредактировать";
            EndModeratingButton.UseVisualStyleBackColor = true;
            EndModeratingButton.Visible = false;
            EndModeratingButton.Click += EndModeratingButton_Click;
            // 
            // Cansel
            // 
            Cansel.Location = new System.Drawing.Point(101, 557);
            Cansel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Cansel.Name = "Cansel";
            Cansel.Size = new System.Drawing.Size(297, 46);
            Cansel.TabIndex = 16;
            Cansel.Text = "Назад";
            Cansel.UseVisualStyleBackColor = true;
            Cansel.Click += Cansel_Click;
            // 
            // NameOfFile
            // 
            NameOfFile.AutoSize = true;
            NameOfFile.Location = new System.Drawing.Point(1019, 661);
            NameOfFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            NameOfFile.Name = "NameOfFile";
            NameOfFile.Size = new System.Drawing.Size(194, 32);
            NameOfFile.TabIndex = 17;
            NameOfFile.Text = "Название файла";
            // 
            // ModeratingText
            // 
            ModeratingText.Location = new System.Drawing.Point(101, 501);
            ModeratingText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ModeratingText.Name = "ModeratingText";
            ModeratingText.Size = new System.Drawing.Size(297, 46);
            ModeratingText.TabIndex = 18;
            ModeratingText.Text = "Редактировать";
            ModeratingText.UseVisualStyleBackColor = true;
            ModeratingText.Click += ModeratingText_Click;
            // 
            // OpenFileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.PeachPuff;
            ClientSize = new System.Drawing.Size(1300, 720);
            Controls.Add(ModeratingText);
            Controls.Add(NameOfFile);
            Controls.Add(Cansel);
            Controls.Add(EndModeratingButton);
            Controls.Add(DeleteTextButton);
            Controls.Add(AddTextButton);
            Controls.Add(ControlScreen);
            Controls.Add(ScreenListBox);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "OpenFileForm";
            Text = "OpenFileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ScreenListBox;
        private System.Windows.Forms.TextBox ControlScreen;
        private System.Windows.Forms.Button AddTextButton;
        private System.Windows.Forms.Button DeleteTextButton;
        private System.Windows.Forms.Button EndModeratingButton;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Label NameOfFile;
        private System.Windows.Forms.Button ModeratingText;
    }
}