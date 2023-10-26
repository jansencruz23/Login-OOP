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
    public partial class Form2 : Form
    {
        private readonly User _user;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(User user)
        {
            _user = user;
            InitializeComponent();
            lblName.Text = _user.FullName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form1();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}
