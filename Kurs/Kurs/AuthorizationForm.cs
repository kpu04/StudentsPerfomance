using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurs
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void EnterIntoAccountButton_Click(object sender, EventArgs e)
        {
            string role = "0";
            bool isRightAccount = DoAuthorization(EnterLoginBox.Text, EnterPasswordBox.Text, ref role);
            if (isRightAccount == true)
            {
                EnterIntoAccountButton.Enabled = false;
                EnterLoginBox.Enabled = false;
                EnterPasswordBox.Enabled = false;
                if (role == "1")
                {
                    AdminMenuForm Menu = new AdminMenuForm();
                    Menu.Show();
                }
                else
                {
                    UserForm UserMenu = new UserForm();
                    UserMenu.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static bool DoAuthorization(string enteredLogin, string enteredPassword, ref string userrole)
        {

            bool isRightAccount = false;
            string[] account = File.ReadAllLines("accounts.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] userData = account[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (string.Compare(userData[0], enteredLogin) == 0 && string.Compare(userData[1], enteredPassword) == 0)
                {
                    userrole = userData[2];
                    return isRightAccount = true;
                }
            }
            return isRightAccount;
        }
    }
}
