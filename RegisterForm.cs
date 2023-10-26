using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindow_1_
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = CreateUser();

            Hide();
            var form = new LoginForm(user);
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private bool IsInputValid() =>
            panelRegister.Controls.OfType<Guna2TextBox>()
                .All(txt => !string.IsNullOrWhiteSpace(txt.Text));

        private User CreateUser() =>
            new ()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Image = imgPic.Image
            };

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new LoginForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void imgPic_Click(object sender, EventArgs e)
        {
            using var file = new OpenFileDialog();
            file.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                imgPic.Image = Image.FromFile(file.FileName);
            }
        }
    }
}