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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            string[] account = File.ReadAllLines("students.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] z = account[i].Split();
                string formattedString = string.Format("{0,-25} \t {1, 10} {2,10} {3,10} {4,10} {5,10} {6,10} {7,10} {8,10}", (z[0] + " " + z[1] + " " + z[2]), z[3], z[4], z[5], z[6], z[7], z[8], z[9], z[10] + "\t");
                Screen.Items.Add(formattedString);
            }
            // Screen.Items.AddRange(account);
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            bool isChecked = true;
            string[] student = { SecondNameBox.Text, NameBox.Text, PatrionBox.Text, FormAducationBox.Text, OffsetBox.Text, Mark1.Text,
                Mark2.Text, Mark3.Text, Mark4.Text, ActiveBox.Text, GroupBox.Text };
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i] == null || student[i] == "")
                {
                    isChecked = false;
                }
            }
            if (isChecked == false)
            {
                MessageBox.Show("Заполните входные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string studentData = $"{SecondNameBox.Text} {NameBox.Text} {PatrionBox.Text} {FormAducationBox.Text} {OffsetBox.Text} {Mark1.Text}" +
                $" {Mark2.Text} {Mark3.Text} {Mark4.Text} {ActiveBox.Text} {GroupBox.Text}";
                Screen.Items.Add(studentData);
                File.AppendAllText("students.txt", $"{studentData}\n");
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Screen.Text == "")
                {
                    MessageBox.Show("Выделите аккаунт для удаления и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string userDataForDelete = Screen.Text;
                    string[] account = File.ReadAllLines("students.txt");
                    FileStream reWrite = new FileStream("students.txt", FileMode.Truncate);
                    reWrite.Close();
                    for (int i = 0; i < account.Length; i++)
                    {
                        if (string.Compare(userDataForDelete, account[i]) != 0)
                        {
                            File.AppendAllText("students.txt", account[i] + "\n");
                        }
                    }
                    Screen.Items.Remove(userDataForDelete);
                    MessageBox.Show("Удаление прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. Выделите текст и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

 //   static string GetLine(ListBox ScreenText)
 //   {
 //       string text = ScreenText.Text;
 //       return text;
 //   }
 //
 //   static string GetText(TextBox ScreenText)
 //   {
 //       string text = ScreenText.Text;
 //       return text;
 //   }
 //
 //   static void DeleteLine(ListBox ScreenText)
 //   {
 //       ScreenText.Items.RemoveAt(ScreenText.SelectedIndex);
 //   }

        private void ModerateStudent_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "")
            {
                MessageBox.Show("Выделите аккаунт для редактирования и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string moderateAccount = Screen.Text;
                string[] moderateAccountData = moderateAccount.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                SecondNameBox.Text = moderateAccountData[0];
                NameBox.Text = moderateAccountData[1];
                PatrionBox.Text = moderateAccountData[2];
                FormAducationBox.Text = moderateAccountData[3];
                OffsetBox.Text = moderateAccountData[4];
                GroupBox.Text = moderateAccountData[10];
                Mark1.Text = moderateAccountData[5];
                Mark2.Text = moderateAccountData[6];
                Mark3.Text = moderateAccountData[7];
                Mark4.Text = moderateAccountData[8];
                ActiveBox.Text = moderateAccountData[9];
                ModerateStudent.Visible = false;
                EndChanges.Visible = true;
                AddStudent.Enabled = false;
                DeleteStudent.Enabled = false;
                View.Enabled = false;
            }
        }

        private void EndChanges_Click(object sender, EventArgs e)
        {
            string userDataForChange = Screen.Text;
            int counter = Screen.SelectedIndex;
            string[] account = File.ReadAllLines("students.txt");
            FileStream reWrite = new FileStream("students.txt", FileMode.Truncate);
            reWrite.Close();
            for (int i = 0; i < account.Length; i++)
            {
                if (string.Compare(userDataForChange, account[i]) != 0)
                {
                    File.AppendAllText("students.txt", account[i] + "\n");
                }
                else
                {
                    File.AppendAllText("students.txt", $"{SecondNameBox.Text} {NameBox.Text} {PatrionBox.Text} {FormAducationBox.Text} {OffsetBox.Text} {Mark1.Text} " +
                $" {Mark2.Text} {Mark3.Text} {Mark4.Text} {ActiveBox.Text} {GroupBox.Text}\n");
                    Screen.Items.Remove(userDataForChange);
                    Screen.Items.Insert(counter, $"{SecondNameBox.Text} {NameBox.Text} {PatrionBox.Text} {FormAducationBox.Text} {OffsetBox.Text} {Mark1.Text}" +
                $" {Mark2.Text} {Mark3.Text} {Mark4.Text} {ActiveBox.Text} {GroupBox.Text}\n");
                }
            }
            MessageBox.Show("Изменения прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EndChanges.Visible = false;
            ModerateStudent.Visible = true;
            AddStudent.Enabled = true;
            DeleteStudent.Enabled = true;
            View.Enabled = true;
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "")
            {
                MessageBox.Show("Выделите аккаунт для удаления и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string moderateAccount = Screen.Text;
                string[] moderateAccountData = moderateAccount.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                SecondNameBox.Text = moderateAccountData[0];
                NameBox.Text = moderateAccountData[1];
                PatrionBox.Text = moderateAccountData[2];
                FormAducationBox.Text = moderateAccountData[3];
                OffsetBox.Text = moderateAccountData[4];
                GroupBox.Text = moderateAccountData[10];
                Mark1.Text = moderateAccountData[5];
                Mark2.Text = moderateAccountData[6];
                Mark3.Text = moderateAccountData[7];
                Mark4.Text = moderateAccountData[8];
                ActiveBox.Text = moderateAccountData[9];
            }
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
