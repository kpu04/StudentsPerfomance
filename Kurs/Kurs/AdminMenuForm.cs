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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            Sort1.Visible = false;
            Sort2.Visible = false;
            GroupSort.Visible = false;
            CanselButton.Visible = true;
            AccountsButton.Visible = false;
            ListOfAccounts.Visible = true;
            AddUserButton.Visible = true;
            DeleteAccountButton.Visible = true;
            ModerateAccountButton.Visible = true;
            WorkWithFilesButton.Visible = false;
            ScholarshipCalculationButton.Visible = false;
            BasicSize.Visible = false;
            BasicSizeBox.Visible = false;
            Search.Visible = false;
            SearchBox.Visible = false;
            Students.Visible = false;
            Reset.Visible = false;
            MenuLabel.Text = "Учетные записи";
            ViewUsers(ListOfAccounts);
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            CanselButton.Visible = false;
            AccountsButton.Visible = true;
            ModerateAccountButton.Visible = false;
            ListOfAccounts.Visible = false;
            AddUserButton.Visible = false;
            AddNewUserButton.Visible = false;
            EnterLoginLabel.Visible = false;
            EnterLoginBox.Visible = false;
            EnterPasswordLabel.Visible = false;
            EnterPasswordBox.Visible = false;
            EnterRoleLabel.Visible = false;
            EnterRoleBox.Visible = false;
            DeleteAccountButton.Visible = false;
            EndChanges.Visible = false;
            WorkWithFilesButton.Visible = true;
            ScholarshipCalculationButton.Visible = true;
            BasicSize.Visible = true;
            BasicSizeBox.Visible = true;
            Students.Visible = true;
            MenuLabel.Text = "Меню";
            BasicSize.Text = "Базовая стипендия(Br):";
        }

        static void ViewUsers(ListBox ListOfAccounts)
        {
            ListOfAccounts.Items.Clear();
            string[] account = File.ReadAllLines("accounts.txt");
            ListOfAccounts.Items.AddRange(account);
        }

        static void AddUser(ListBox ListOfAccounts)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            EnterLoginLabel.Visible = true;
            EnterLoginBox.Visible = true;
            EnterPasswordLabel.Visible = true;
            EnterPasswordBox.Visible = true;
            EnterRoleLabel.Visible = true;
            EnterRoleBox.Visible = true;
            AddNewUserButton.Visible = true;
            AccountsButton.Visible = false;
            EndChanges.Visible = false;
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (EnterLoginBox.Text != "" && EnterPasswordBox.Text != "" && EnterRoleBox.Text != "")
            {
                User newAccountData;
                FillingOutAnAccount(EnterLoginBox.Text, EnterPasswordBox.Text, EnterRoleBox.Text, out newAccountData);
                bool matches = CheckForCoincidences(EnterLoginBox);
                if (matches == false)
                {
                    File.AppendAllText("accounts.txt", $"{newAccountData.login} {newAccountData.password} {newAccountData.role}\n");
                    ListOfAccounts.Items.Add($"{newAccountData.login} {newAccountData.password} {newAccountData.role}");
                    MessageBox.Show("Аккаунт создан успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Аккаунт с таким именем уже существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static bool CheckForCoincidences(TextBox login)
        {
            bool match = false;
            string[] account = File.ReadAllLines("accounts.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] userData = account[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (string.Compare(userData[0], login.Text) == 0)
                {
                    match = true;
                }
            }
            return match;
        }

        static void FillingOutAnAccount(string login, string password, string role, out User newAccountData)
        {
            newAccountData.login = login;
            newAccountData.password = password;
            newAccountData.role = role;
        }

        struct User
        {
            public string login;
            public string password;
            public string role;
            public User(string log, string pass, string r)
            {
                login = log;
                password = pass;
                role = r;
            }
        };

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListOfAccounts.Text == "")
                {
                    MessageBox.Show("Выделите аккаунт для удаления и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string userDataForDelete = ListOfAccounts.Text;
                    string[] account = File.ReadAllLines("accounts.txt");
                    FileStream reWrite = new FileStream("accounts.txt", FileMode.Truncate);
                    reWrite.Close();
                    for (int i = 0; i < account.Length; i++)
                    {
                        if (string.Compare(userDataForDelete, account[i]) != 0)
                        {
                            File.AppendAllText("accounts.txt", account[i] + "\n");
                        }
                    }
                    ListOfAccounts.Items.Remove(userDataForDelete);
                    MessageBox.Show("Удаление прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка. Выделите текст и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModerateAccountButton_Click(object sender, EventArgs e)
        {
            if (ListOfAccounts.Text == "")
            {
                MessageBox.Show("Выделите аккаунт для удаления и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string moderateAccount = ListOfAccounts.Text;
                string[] moderateAccountData = moderateAccount.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                EnterLoginBox.Text = moderateAccountData[0];
                EnterPasswordBox.Text = moderateAccountData[1];
                EnterRoleBox.Text = moderateAccountData[2];
                EnterLoginLabel.Visible = true;
                EnterLoginBox.Visible = true;
                EnterPasswordLabel.Visible = true;
                EnterPasswordBox.Visible = true;
                EnterRoleLabel.Visible = true;
                EnterRoleBox.Visible = true;
                EndChanges.Visible = true;
            }
        }

        private void EndChanges_Click(object sender, EventArgs e)
        {
            if (ListOfAccounts.Text == "")
            {
                MessageBox.Show("Выделите аккаунт для удаления и повторите попытку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User newAccountData;
                string userDataForChange = ListOfAccounts.Text;
                int counter = ListOfAccounts.SelectedIndex;
                string[] account = File.ReadAllLines("accounts.txt");
                FileStream reWrite = new FileStream("accounts.txt", FileMode.Truncate);
                reWrite.Close();
                for (int i = 0; i < account.Length; i++)
                {
                    if (string.Compare(userDataForChange, account[i]) != 0)
                    {
                        File.AppendAllText("accounts.txt", account[i] + "\n");
                    }
                    else
                    {
                        FillingOutAnAccount(EnterLoginBox.Text, EnterPasswordBox.Text, EnterRoleBox.Text, out newAccountData);
                        File.AppendAllText("accounts.txt", $"{newAccountData.login} {newAccountData.password} {newAccountData.role}\n");
                        ListOfAccounts.Items.Remove(userDataForChange);
                        ListOfAccounts.Items.Insert(counter, $"{newAccountData.login} {newAccountData.password} {newAccountData.role}\n");
                    }
                }
                MessageBox.Show("Изменение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WorkWithFilesButton_Click(object sender, EventArgs e)
        {
            AdminFileForm FileWorkForm = new AdminFileForm();
            FileWorkForm.Show();
        }

        private void ScholarshipCalculationButton_Click(object sender, EventArgs e)
        {
            ListOfAccounts.Visible = true;
            ListOfAccounts.Items.Clear();
            string[] account = File.ReadAllLines("students.txt");
            try
            {
                for (int i = 0; i < account.Length; i++)
                {
                    string[] studentData = account[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double averageGrade = CalculateAverageGrade(studentData);
                    if (averageGrade >= 5 && studentData[3] == "бюджетная" && studentData[4] == "зачет")
                    {
                        double scholarship = CalculateScholarship(Convert.ToDouble(BasicSizeBox.Text), averageGrade, Convert.ToInt32(studentData[9]));
                        ListOfAccounts.Items.Add(GetStudentInfo(studentData[0], studentData[1], studentData[10], averageGrade, scholarship));
                    }
                }
                Sort1.Visible = true;
                Sort2.Visible = true;
                GroupSort.Visible = true;
                Search.Visible = true;
                SearchBox.Visible = true;
                Search.Enabled = true;
                Reset.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Проверьте введённую информацию", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListOfAccounts.Visible = false;
            }
        }

        static string GetStudentInfo(string name, string secondName, string group, double averageGrade, double scholarship)
        {
            string text = $"{name} {secondName}, группа {group}, средний балл - {averageGrade}, стипендия - {scholarship}";
            return text;
        }

        static double CalculateAverageGrade(string[] studentData)
        {
            double averageGrade = (Convert.ToInt32(studentData[5]) + Convert.ToInt32(studentData[6]) +
                    Convert.ToInt32(studentData[7]) + Convert.ToInt32(studentData[8])) / 4;
            return averageGrade;
        }
        static double CalculateScholarship(double basicScholarship, double averageGrade, int role)
        {
            double scholarship = basicScholarship;
            if (role == 1 && averageGrade >= 9)
            {
                scholarship *= 1.5;
            }
            else if (role == 0 && averageGrade >= 9)
            {
                scholarship *= 1.25;
            }
            return scholarship;
        }

        private void Sort1_Click(object sender, EventArgs e)
        {
            string[] students = new string[ListOfAccounts.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ListOfAccounts.Items[i].ToString();
            }
            SortList(students);
            ListOfAccounts.Items.Clear();
            ListOfAccounts.Items.AddRange(students);
        }

        static string[] SortList(string[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (string.Compare(students[i], students[j]) > 0)
                    {
                        string revers = students[i];
                        students[i] = students[j];
                        students[j] = revers;
                    }
                }
            }
            return students;
        }

        private void Sort2_Click(object sender, EventArgs e)
        {
            string[] students = new string[ListOfAccounts.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ListOfAccounts.Items[i].ToString();
            }
            SortListReverse(students);
            ListOfAccounts.Items.Clear();
            ListOfAccounts.Items.AddRange(students);
        }

        static string[] SortListReverse(string[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (string.Compare(students[i], students[j]) < 0)
                    {
                        string revers = students[i];
                        students[i] = students[j];
                        students[j] = revers;
                    }
                }
            }
            return students;
        }

        private void GroupSort_Click(object sender, EventArgs e)
        {
            string[] students = new string[ListOfAccounts.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ListOfAccounts.Items[i].ToString();
            }
            SortByGroups(students);
            ListOfAccounts.Items.Clear();
            ListOfAccounts.Items.AddRange(students);
        }

        static string[] SortByGroups(string[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    string[] studentsData = students[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] studentsData2 = students[j].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Convert.ToInt32(studentsData[3]) > Convert.ToInt32(studentsData2[3]))
                    {
                        string reverse = students[i];
                        students[i] = students[j];
                        students[j] = reverse;
                    }
                }
            }
            return students;
        }

        private void Students_Click(object sender, EventArgs e)
        {
            Students studForm = new Students();
            studForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int counter = ListOfAccounts.Items.Count;
            string[] list = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                list[i] = ListOfAccounts.Items[i].ToString();
            }
            ListOfAccounts.Items.Clear();
            for (int i = 0; i < counter; i++)
            {
                string[] compareList = list[i].Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < compareList.Length; j++)
                {
                    if (SearchBox.Text == "")
                    {
                        ListOfAccounts.Items.Clear();
                        ListOfAccounts.Items.AddRange(list);
                    }
                    else
                    {
                        if (SearchBox.Text == compareList[j])
                        {
                            ListOfAccounts.Items.Add(list[i]);
                        }

                    }
                }
            }
            Search.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ListOfAccounts.Items.Clear();
            string[] account = File.ReadAllLines("students.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] studentData = account[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double averageGrade = CalculateAverageGrade(studentData);
                if (averageGrade >= 5 && studentData[3] == "бюджетная" && studentData[4] == "зачет")
                {
                    double scholarship = CalculateScholarship(Convert.ToDouble(BasicSizeBox.Text), averageGrade, Convert.ToInt32(studentData[10]));
                    ListOfAccounts.Items.Add(GetStudentInfo(studentData[0], studentData[1], studentData[10], averageGrade, scholarship));
                }
            }
            Search.Enabled = true;
        }
    }
}