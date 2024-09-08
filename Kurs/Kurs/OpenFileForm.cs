using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kurs
{
    public partial class OpenFileForm : Form
    {
        public OpenFileForm(string fileName)
        {
            InitializeComponent();
            try
            {
                ScreenListBox.Items.Clear();
                if (fileName == "")
                {
                    this.Dispose();
                }
                else
                {
                    string[] file = File.ReadAllLines(fileName);
                    ScreenListBox.Items.AddRange(file);
                    NameOfFile.Text = fileName;
                }
            }
            catch
            {
                this.Dispose();
            }
        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(GetText(ControlScreen) == "" || GetText(ControlScreen) == null)
                {
                    MessageBox.Show("Ошибка! Введите текст для добавления!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    File.AppendAllText(NameOfFile.Text, $"{GetText(ControlScreen)}\n");
                    ScreenListBox.Items.Clear();
                    string[] file = File.ReadAllLines(NameOfFile.Text);
                    ScreenListBox.Items.AddRange(file);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Перед добавлением текста откройте файл/введите текст для добавления", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string GetText(TextBox ScreenText)
        {
            string text = ScreenText.Text;
            return text;
        }

        private void DeleteTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] account = File.ReadAllLines(NameOfFile.Text);
                FileStream reWrite = new FileStream(NameOfFile.Text, FileMode.Truncate);
                reWrite.Close();
                for (int i = 0; i < account.Length; i++)
                {
                    if (string.Compare(GetLine(ScreenListBox), account[i]) != 0)
                    {
                        File.AppendAllText(NameOfFile.Text, account[i] + "\n");
                    }
                }
                DeleteLine(ScreenListBox);
            }
            catch
            {
                MessageBox.Show("Ошибка! Перед удалением откройте файл/выберите текст для удаления", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static void DeleteLine(ListBox ScreenText)
        {
            ScreenText.Items.RemoveAt(ScreenText.SelectedIndex);
        }

        static string GetLine(ListBox ScreenText)
        {
            string text = ScreenText.Text;
            return text;
        }

        private void ModeratingText_Click(object sender, EventArgs e)
        {
            ControlScreen.Text = GetLine(ScreenListBox);
            EndModeratingButton.Visible = true;
            ModeratingText.Visible = false;
            AddTextButton.Enabled = false;
            DeleteTextButton.Enabled = false;
        }

        private void EndModeratingButton_Click(object sender, EventArgs e)
        {
            try
            {
                ModeratingText.Visible = true;
                EndModeratingButton.Visible = false;
                ScreenListBox.Items.Insert(GetIndex(ScreenListBox), GetText(ControlScreen));
                string[] account = File.ReadAllLines(NameOfFile.Text);
                FileStream reWrite = new FileStream(NameOfFile.Text, FileMode.Truncate);
                reWrite.Close();
                for (int i = 0; i < account.Length; i++)
                {
                    if (string.Compare(GetLine(ScreenListBox), account[i]) != 0)
                    {
                        File.AppendAllText(NameOfFile.Text, account[i] + "\n");
                    }
                    else
                    {
                        File.AppendAllText(NameOfFile.Text, GetText(ControlScreen) + "\n");
                    }
                }
                DeleteLine(ScreenListBox);
                ControlScreen.Text = null;
                AddTextButton.Enabled = true;
                DeleteTextButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка! Перед редактированием текста откройте файл/выберите текст для редактирования", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddTextButton.Enabled = true;
                DeleteTextButton.Enabled = true;
            }
        }

        static int GetIndex(ListBox ScreenText)
        {
            return ScreenText.SelectedIndex;
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
