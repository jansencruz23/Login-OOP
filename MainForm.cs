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
    public partial class MainForm : Form
    {
        private readonly User _user;

        public MainForm(User user)
        {
            _user = user;
            InitializeComponent();
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            lblName.Text = _user.FullName;
            imgPic.Image = _user.Image;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new LoginForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}