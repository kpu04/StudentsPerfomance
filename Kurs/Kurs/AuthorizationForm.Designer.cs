
namespace Kurs
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            EnterPasswordBox = new System.Windows.Forms.TextBox();
            EnterIntoAccountButton = new System.Windows.Forms.Button();
            EnterPasswordLabel = new System.Windows.Forms.Label();
            EnterLoginBox = new System.Windows.Forms.TextBox();
            EnterLoginLabel = new System.Windows.Forms.Label();
            AuthorizationLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // EnterPasswordBox
            // 
            EnterPasswordBox.Location = new System.Drawing.Point(67, 283);
            EnterPasswordBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterPasswordBox.Name = "EnterPasswordBox";
            EnterPasswordBox.PasswordChar = '*';
            EnterPasswordBox.Size = new System.Drawing.Size(345, 39);
            EnterPasswordBox.TabIndex = 0;
            // 
            // EnterIntoAccountButton
            // 
            EnterIntoAccountButton.BackColor = System.Drawing.SystemColors.Control;
            EnterIntoAccountButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            EnterIntoAccountButton.Location = new System.Drawing.Point(160, 348);
            EnterIntoAccountButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterIntoAccountButton.Name = "EnterIntoAccountButton";
            EnterIntoAccountButton.Size = new System.Drawing.Size(160, 52);
            EnterIntoAccountButton.TabIndex = 1;
            EnterIntoAccountButton.Text = "Войти";
            EnterIntoAccountButton.UseVisualStyleBackColor = false;
            EnterIntoAccountButton.Click += EnterIntoAccountButton_Click;
            // 
            // EnterPasswordLabel
            // 
            EnterPasswordLabel.AutoSize = true;
            EnterPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            EnterPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            EnterPasswordLabel.Location = new System.Drawing.Point(129, 241);
            EnterPasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EnterPasswordLabel.Name = "EnterPasswordLabel";
            EnterPasswordLabel.Size = new System.Drawing.Size(227, 37);
            EnterPasswordLabel.TabIndex = 2;
            EnterPasswordLabel.Text = "Введите пароль";
            // 
            // EnterLoginBox
            // 
            EnterLoginBox.Location = new System.Drawing.Point(67, 181);
            EnterLoginBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            EnterLoginBox.Name = "EnterLoginBox";
            EnterLoginBox.Size = new System.Drawing.Size(345, 39);
            EnterLoginBox.TabIndex = 3;
            // 
            // EnterLoginLabel
            // 
            EnterLoginLabel.AutoSize = true;
            EnterLoginLabel.BackColor = System.Drawing.Color.Transparent;
            EnterLoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            EnterLoginLabel.Location = new System.Drawing.Point(145, 129);
            EnterLoginLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            EnterLoginLabel.Name = "EnterLoginLabel";
            EnterLoginLabel.Size = new System.Drawing.Size(211, 37);
            EnterLoginLabel.TabIndex = 4;
            EnterLoginLabel.Text = "Введите логин";
            // 
            // AuthorizationLabel
            // 
            AuthorizationLabel.AutoSize = true;
            AuthorizationLabel.BackColor = System.Drawing.Color.Transparent;
            AuthorizationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            AuthorizationLabel.Location = new System.Drawing.Point(128, 19);
            AuthorizationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            AuthorizationLabel.Name = "AuthorizationLabel";
            AuthorizationLabel.Size = new System.Drawing.Size(237, 45);
            AuthorizationLabel.TabIndex = 5;
            AuthorizationLabel.Text = "Авторизация";
            AuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(481, 437);
            Controls.Add(AuthorizationLabel);
            Controls.Add(EnterLoginLabel);
            Controls.Add(EnterLoginBox);
            Controls.Add(EnterPasswordLabel);
            Controls.Add(EnterIntoAccountButton);
            Controls.Add(EnterPasswordBox);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "AuthorizationForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox EnterPasswordBox;
        private System.Windows.Forms.Button EnterIntoAccountButton;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.TextBox EnterLoginBox;
        private System.Windows.Forms.Label EnterLoginLabel;
        private System.Windows.Forms.Label AuthorizationLabel;
    }
}

