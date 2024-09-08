using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        private void StartWork_Click(object sender, EventArgs e)
        {
            AuthorizationForm Autherization = new AuthorizationForm();
            Autherization.Show();
            this.Hide();
        }
    }
}
