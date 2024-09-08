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
    public partial class AdminFileForm : Form
    {
        public AdminFileForm()
        {
            InitializeComponent();
        }

        private void FileCreating_Click(object sender, EventArgs e)
        {
            NameOfFileBox.Visible = true;
            CreatNewFileButton.Visible = true;
            CreateFileLabel.Visible = true;
            FileDeleteButton.Visible = false;
            OpenButton.Visible = false;
            CreateFileLabel.Text = "Введите имя и расширение файла";
        }

        private void CreatNewFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nameFile = GetFileName(NameOfFileBox);
                if (nameFile != "accounts.txt" || nameFile != "students.txt")
                {
                    FileStream fileCreate = new FileStream(nameFile, FileMode.Create);
                    fileCreate.Close();
                    MessageBox.Show("Файл создан успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы не можете пересоздать файл с таким названием", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Укажите название файла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FileDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileDelete = new FileInfo(GetFileName(NameOfFileBox));
                if (fileDelete.Exists)
                {
                    fileDelete.Delete();
                    MessageBox.Show("Файл удален успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файла с таким названием не существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Укажите название файла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FileDeleting_Click(object sender, EventArgs e)
        {
            NameOfFileBox.Visible = true;
            CreatNewFileButton.Visible = false;
            CreateFileLabel.Visible = true;
            FileDeleteButton.Visible = true;
            OpenButton.Visible = false;
            CreateFileLabel.Text = "Введите имя и расширение файла";
        }

        static string GetFileName(TextBox NameOfFile)
        {
            string fileName = NameOfFile.Text;
            return fileName;
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            NameOfFileBox.Visible = true;
            CreateFileLabel.Visible = true;
            CreatNewFileButton.Visible = false;
            FileDeleteButton.Visible = false;
            OpenButton.Visible = true;
            CreateFileLabel.Text = "Введите имя и расширение файла";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileForm openFile = new OpenFileForm(NameOfFileBox.Text);
            try
            {
                openFile.Show();
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

        static string GetLine(ListBox ScreenText)
        {
            string text = ScreenText.Text;
            return text;
        }

        static void DeleteLine(ListBox ScreenText)
        {
            ScreenText.Items.RemoveAt(ScreenText.SelectedIndex);
        }

        static int GetIndex(ListBox ScreenText)
        {
            return ScreenText.SelectedIndex;
        }
    }
}
