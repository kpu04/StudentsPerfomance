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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Sort1.Visible = false;
            Sort2.Visible = false;
            GroupSort.Visible = false;
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

        static string GetFileName(TextBox NameOfFile)
        {
            string fileName = NameOfFile.Text;
            return fileName;
        }

        private void ScholarshipCalculationButton_Click(object sender, EventArgs e)
        {
            ScreenListBox.Visible = true;
            ScreenListBox.Items.Clear();
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
                        ScreenListBox.Items.Add(GetStudentInfo(studentData[0], studentData[2], studentData[10], averageGrade, scholarship));
                    }
                }
                Sort1.Visible = true;
                Sort2.Visible = true;
                GroupSort.Visible = true;
                Search.Enabled = true;
                SearchBox.Visible = true;
                Search.Visible = true;
                Reset.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Проверьте введённую информацию", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ScreenListBox.Visible = false;
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
            string[] students = new string[ScreenListBox.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ScreenListBox.Items[i].ToString();
            }
            SortList(students);
            ScreenListBox.Items.Clear();
            ScreenListBox.Items.AddRange(students);
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
            string[] students = new string[ScreenListBox.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ScreenListBox.Items[i].ToString();
            }
            SortListReverse(students);
            ScreenListBox.Items.Clear();
            ScreenListBox.Items.AddRange(students);
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
            string[] students = new string[ScreenListBox.Items.Count];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = ScreenListBox.Items[i].ToString();
            }
            SortByGroups(students);
            ScreenListBox.Items.Clear();
            ScreenListBox.Items.AddRange(students);
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
            int counter = ScreenListBox.Items.Count;
            string[] list = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                list[i] = ScreenListBox.Items[i].ToString();
            }
            ScreenListBox.Items.Clear();
            for (int i = 0; i < counter; i++)
            {
                string[] compareList = list[i].Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < compareList.Length; j++)
                {
                    if (SearchBox.Text == "")
                    {
                        ScreenListBox.Items.Clear();
                        ScreenListBox.Items.AddRange(list);
                    }
                    else
                    {
                        if (SearchBox.Text == compareList[j])
                        {
                            ScreenListBox.Items.Add(list[i]);
                        }

                    }
                }
            }
            Search.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ScreenListBox.Items.Clear();
            string[] account = File.ReadAllLines("students.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] studentData = account[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double averageGrade = CalculateAverageGrade(studentData);
                if (averageGrade >= 5 && studentData[3] == "бюджетная" && studentData[4] == "зачет")
                {
                    double scholarship = CalculateScholarship(Convert.ToDouble(BasicSizeBox.Text), averageGrade, Convert.ToInt32(studentData[10]));
                    ScreenListBox.Items.Add(GetStudentInfo(studentData[0], studentData[1], studentData[10], averageGrade, scholarship));
                }
            }
            Search.Enabled = true;
        }
    }
}
