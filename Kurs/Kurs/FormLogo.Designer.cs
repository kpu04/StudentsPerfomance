
namespace Kurs
{
    partial class FormLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogo));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            StartWork = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gold;
            label1.Location = new System.Drawing.Point(75, 9);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(857, 45);
            label1.TabIndex = 0;
            label1.Text = "Вас приветствует программа расчёта стипендий!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Gold;
            label2.Location = new System.Drawing.Point(191, 66);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(658, 37);
            label2.TabIndex = 1;
            label2.Text = "Для продолжения выберите \"Начать работу\"";
            // 
            // StartWork
            // 
            StartWork.ForeColor = System.Drawing.Color.Black;
            StartWork.Location = new System.Drawing.Point(373, 535);
            StartWork.Margin = new System.Windows.Forms.Padding(5);
            StartWork.Name = "StartWork";
            StartWork.Size = new System.Drawing.Size(245, 46);
            StartWork.TabIndex = 2;
            StartWork.Text = "Начать работу";
            StartWork.UseVisualStyleBackColor = true;
            StartWork.Click += StartWork_Click;
            // 
            // FormLogo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.OldLace;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(990, 595);
            Controls.Add(StartWork);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.SystemColors.Highlight;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "FormLogo";
            Text = "Расчёт стипендий";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartWork;
    }
}